// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Yarp.ReverseProxy.Configuration;
using System.Linq;

namespace Yarp.Sample
{
    /// <summary>
    /// Extends the IReverseProxyBuilder to support the InMemoryConfigProvider
    /// </summary>
    public static class InMemoryConfigProviderExtensions
    {
        public static IReverseProxyBuilder LoadFromMemory(this IReverseProxyBuilder builder)
        {
            builder.Services.AddSingleton<IProxyConfigProvider>(
                new InMemoryConfigProvider(Array.Empty<RouteConfig>(), Array.Empty<ClusterConfig>()));

            return builder;
        }
    }

    /// <summary>
    /// Provides an implementation of IProxyConfigProvider to support config being generated by code. 
    /// </summary>
    public class InMemoryConfigProvider : IProxyConfigProvider
    {
        // Marked as volatile so that updates are atomic
        private volatile InMemoryConfig _config;

        public InMemoryConfigProvider(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
        {
            _config = new InMemoryConfig(routes, clusters);
        }

        /// <summary>
        /// Implementation of the IProxyConfigProvider.GetConfig method to supply the current snapshot of configuration
        /// </summary>
        /// <returns>An immutable snapshot of the current configuration state</returns>
        public IProxyConfig GetConfig() => _config;

        /// <summary>
        /// Swaps the config state with a new snapshot of the configuration, then signals the change
        /// </summary>
        public void Update(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
        {
            var oldConfig = _config;
            _config = new InMemoryConfig(routes, clusters);
            oldConfig.SignalChange();
        }

        public void AddWeb(string hostName)
        {
            var oldConfig = _config;

            var newRoutes = oldConfig.Routes.ToList();
            newRoutes.Add(new RouteConfig
            {
                ClusterId = hostName,
                RouteId = hostName,
                Match = new RouteMatch { Hosts = new string[] { hostName } }
            });

            var newClusters = oldConfig.Clusters.ToList();
            newClusters.Add(new ClusterConfig
            {
                ClusterId = hostName,
                Destinations = new Dictionary<string, DestinationConfig>(StringComparer.OrdinalIgnoreCase)
                {
                     { "default", new DestinationConfig() {Address = $"http://{hostName}",} }
                }
            });

            _config = new InMemoryConfig(newRoutes, newClusters);
            oldConfig.SignalChange();
        }

        /// <summary>
        /// Implementation of IProxyConfig which is a snapshot of the current config state. The data for this class should be immutable.
        /// </summary>
        private class InMemoryConfig : IProxyConfig
        {
            // Used to implement the change token for the state
            private readonly CancellationTokenSource _cts = new CancellationTokenSource();

            public InMemoryConfig(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
            {
                Routes = routes;
                Clusters = clusters;
                ChangeToken = new CancellationChangeToken(_cts.Token);
            }

            /// <summary>
            /// A snapshot of the list of routes for the proxy
            /// </summary>
            public IReadOnlyList<RouteConfig> Routes { get; }

            /// <summary>
            /// A snapshot of the list of Clusters which are collections of interchangable destination endpoints
            /// </summary>
            public IReadOnlyList<ClusterConfig> Clusters { get; }

            /// <summary>
            /// Fired to indicate the the proxy state has changed, and that this snapshot is now stale
            /// </summary>
            public IChangeToken ChangeToken { get; }

            internal void SignalChange()
            {
                _cts.Cancel();
            }
        }
    }
}

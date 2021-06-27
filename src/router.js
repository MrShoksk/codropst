import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/search',
      name: 'search',
      component: () => import('./views/Search.vue')
    },
    {
      path: '/personal',
      name: 'personal',
      component: () => import('./views/Personal.vue')
    },
    {
      path: '/player',
      name: 'player',
      component: () => import('./views/Player.vue')
    },
    {
      path: '/classify',
      name: 'classify',
      component: () => import('./views/Classify.vue')
    },
    {
      path: '/upload',
      name: 'upload',
      component: () => import('./views/Upload.vue')
    }
  ]
})

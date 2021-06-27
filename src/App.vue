<template>
  <div id="app">
    <div class="header-container">
      <img class="logo" src="../public/logo.png" alt="" />
      <p class="title">有声爱好者网站</p>
      <ul>
        <router-link to="/"><li>首页</li></router-link>
        <router-link to="/classify"><li>分类</li></router-link>
        <li>此处最多九个字啊啊</li>
        <router-link to="/player"><li>播放器</li></router-link>
        <router-link to="/personal"><li>个人空间</li></router-link>
      </ul>
      <div class="box" @click="toSearch">搜索框</div>
      <div class="user" v-if="isLogin == 1">
        <img src="../public/photo2.png" alt="" />
        <div class="name">
          <div>纳新</div>
          <div>已登录</div>
        </div>
      </div>
      <div class="login-btn" v-if="isLogin == 0">
        <div class="btn" @click="toDL">登录</div>
        |
        <div class="btn" @click="toZC">注册</div>
      </div>
    </div>
    <router-view
      @logoutUser="logoutUser"
      @login="login"
      :typen="typen"
    ></router-view>
    <audio
      loop="loop"
      preload="preload"
      id="bgmusic"
      controls="controls"
      ref="MusicPlay"
      style="display: none"
    >
      <source src="" type="audio/mpeg" />
    </audio>
  </div>
</template>
<script>
export default {
  data() {
    return {
      audioUrl: require("../public/audio/刘至佳_韩瞳-时光背面的我.mp3"),
      typen: 1,
      isLogin: 0,
    };
  },
  methods: {
    toSearch() {
      this.$router.push("/search");
    },
    logoutUser(user) {
      console.log("logout App.vue", user);
      this.isLogin = user;
    },
    login(isLogin) {
      console.log(isLogin);
    },
    toDL() {
      this.$router.push("/personal");
      this.typen = 1;
    },
    toZC() {
      this.$router.push("/personal");
      this.typen = 3;
    },
  },
  mounted() {
    const userInfo = localStorage.getItem('userInfo')
    if (userInfo) {
      this.isLogin = 1
    }else {
      this.isLogin = 0
    }
  },
};
</script>
<style lang="less">
html,
body,
div,
ul,
li,
h1,
h2,
h3,
h4,
h5,
h6,
p,
dl,
dt,
dd,
ol,
form,
input,
textarea,
th,
td,
select {
  margin: 0;
  padding: 0;
}
* {
  box-sizing: border-box;
}
a {
  text-decoration: none;
}
body {
  background-color: rgb(245, 245, 245);
}
.header-container {
  width: 100%;
  height: 80px;
  background-color: #242424;
  display: flex;
  align-items: center;
}
.header-container .logo {
  width: 50px;
  height: 50px;
  margin-left: 120px;
}
.header-container .title {
  font-size: 24px;
  color: rgb(243, 235, 235);
  margin-left: 10px;
}
.header-container ul {
  display: flex;
}
.header-container ul li {
  list-style: none;
  width: 150px;
  height: 80px;
  line-height: 80px;
  text-align: center;
  color: #cccccc;
}
.header-container ul li:hover {
  background-color: black;
  cursor: pointer;
}
.header-container .box {
  width: 300px;
  height: 28px;
  background-color: #fff;
  border-radius: 12px;
  margin-left: 28px;
  text-align: center;
  line-height: 28px;
}
.login-btn {
  width: 120px;
  height: 32px;
  border: 1px solid #eee;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  color: #cccccc;
  margin-left: 28px;
}
.login-btn .btn {
  color: #cccccc;
  cursor: pointer;
}
.header-container .user {
  display: flex;
  align-items: center;
}
.header-container .user img {
  width: 44px;
  height: 44px;
  margin-left: 60px;
}
.header-container .user .name {
  color: rgb(216, 211, 211);
  margin-left: 10px;
}
.header-container .user .name div:last-child {
  font-size: 12px;
  color: #cccccc;
}
</style>

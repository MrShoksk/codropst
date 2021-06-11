<template>
  <div id="app">
    <div class="header-container">
      <img class="logo" src="../public/logo.png" alt="" />
      <p class="title">有声爱好者网站</p>
      <ul>
        <li>首页</li>
        <li>此处最多九个字啊啊</li>
        <li>2</li>
        <li>3</li>
        <li>4</li>
      </ul>
      <div class="box">按钮</div>
      <div class="login-btn">
        <div class="btn">登录</div>
        |
        <div class="btn">注册</div>
      </div>
    </div>
    <div class="banner">
      <img src="../public/banner.jpg" alt="" />
    </div>
    <div class="main">
      <div class="recommend">
        <div class="recommend-title">
          <img class="icon" src="../public/hot.png" alt=""/>
          <p class="title1">热门推荐</p>
          <ul>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
          </ul>
          <p class="more">更多</p>
        </div>
        <div class="line"></div>
        <div class="books">
          <div class="book"></div>
          <div class="book"></div>
          <div class="book"></div>
          <div class="book"></div>
          <div class="book"></div>
          <div class="book"></div>
        </div>
      </div>
    </div>
  </div>
</template>

<style lang="less">
body,
html {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}
.header-container {
  width: 100vw;
  height: 80px;
  background-color: #242424;
  display: flex;
  align-items: center;
}
.logo {
  width: 50px;
  height: 50px;
  margin-left: 120px;
}
.title {
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
.box {
  width: 100px;
  height: 50px;
  background-color: #fff;
  border-radius: 12px;
  margin-left: 28px;
  text-align: center;
  line-height: 50px;
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
.banner {
  width: 100vw;
  text-align: center;
  background-color: #1d1f20;
}
.banner img {
  width: 1180px;
  height: 280px;
}
.main {
  width: 1180px;
  margin: 0 auto;
}
.main .title1 {
  font-size: 22px;
  font-weight: 500;
}
.icon {
  width: 32px;
  height: 32px;
}
.recommend-title {
  width: 640px;
  display: flex;
  align-items: center;
  height: 54px;
}
.recommend-title p {
  margin-left: 10px;
}
.recommend-title ul {
  display: flex;
  list-style: none;
}
.recommend-title ul li {
  margin-right: 14px;
  font-size: 14px;
  margin-top: 8px;
}
.recommend-title .more {
  margin-left: 200px;
}
.line {
  width: 640px;
  height: 2px;
  background-color: #ccc;
}
</style>

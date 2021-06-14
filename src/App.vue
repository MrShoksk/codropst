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
          <img class="icon" src="../public/hot.png" alt="" />
          <p class="title1">热门推荐</p>
          <ul>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
          </ul>
          <div class="more">更多<img src="../public/right.png" alt=""></div>
        </div>
        <div class="line"></div>
        <div class="books">
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
          <div class="book"><img src="../public/book.jpg" alt="" />
          <p>神话故事：蜗牛故事有声版</p></div>
        </div>
    <div style="height:20px;"></div>
      </div>
    </div>
    <div style="height:50px;"></div>
  </div>
</template>

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
.header-container {
  width: 100%;
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
  width: 100%;
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
.recommend {
  padding: 0 20px;
  border: 1px solid #cccccc;
  width: 800px;
}
.recommend-title {
  width: 100%;
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
  margin-left: 40px;
}
.recommend-title ul li {
  margin-right: 14px;
  font-size: 14px;
  margin-top: 8px;
}
.recommend-title .more {
  margin-left: 320px;
  display: flex;
  align-items: center;
}
.recommend-title .more img {
  width: 14px;
  height: 14px;
  margin-left: 10px;
}
.line {
  width: 760px;
  height: 2px;
  background-color: #ccc;
}
.books {
  width: 760px;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-evenly;
}
.books .book {
  width: 162px;
  height: 240px;
  margin-top: 20px;
  border: 1px solid #eee;
}
.books .book img {
  width: 100%;
  height: 180px;
}
.books .book P {
  font-size: 14px;
  margin: 8px 6px;
}
</style>

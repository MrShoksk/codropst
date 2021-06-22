<template>
  <div class="personal-container">
    <div class="main">
      <div class="title">
        作者中心
      </div>
      <div class="parts">
        <div class="part">
          <img src="../../public/music.png" alt="">
          <p>录制作品</p>
          <p>说出你的故事</p>
        </div>
        <div class="part">
          <img src="../../public/up.png" alt="">
          <p>上传作品</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part">
          <img src="../../public/mine.png" alt="">
          <p>我的作品</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part" style="opacti">
          <img src="../../public/setting.png" alt="">
          <p>账号设置</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part" style="opacity:0;">
         
        </div>
        <div class="part" style="opacity:0;">
         
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {

}
</script>

<style scoped>
.main {
  width: 1180px;
  height: 600px;
  margin: 0 auto;
}
.main .title {
  font-size: 44px;
  font-family: 'Yu Gothic Light';
  font-weight: 500;
  margin-top: 40px;
  margin-left: 40px;
}
.parts {
  width: 100%;
  margin-top: 40px;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-evenly;
}
.parts .part {
  width: 320px;
  height: 200px;
  background-color: rgb(255, 255, 255);
  border-radius: 12px;
  display: flex;
  flex-direction: column;
  align-items: center;
  margin-bottom: 20px;
}
.parts .part img {
  width: 60px;
  height: 60px;
  margin-top: 20px;
}
.parts .part p {
  font-size: 32px;
  margin-top: 10px;
}
.parts .part p:last-child {
  font-size: 16px;
  color: rgb(196, 194, 194);
}
</style>>
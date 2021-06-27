<template>
  <div class="home">
    <div class="banner">
      <img src="../../public/banner.jpg" alt="" />
    </div>
    <div class="main">
      <div class="recommend">
        <div class="recommend-title">
          <img class="icon" src="../../public/hot.png" alt="" />
          <p class="title1">热门推荐</p>
          <ul>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
            <li>音乐</li>
          </ul>
          <div class="more">
            更多<img src="../../public/right.png" alt="" />
          </div>
        </div>
        <div class="line"></div>
        <div class="books">
          <div class="book" v-for="item in list" :key="item.id">
            <img :src="item.img" alt="" />
            <p>{{item.type}}：{{item.name}}</p>
          </div>
        </div>
        <div style="height: 20px"></div>
      </div>
      <div class="slider">
        <div class="slider-title">热门作者</div>
        <div class="more2">更多</div>
        <img class="more-icon" src="../../public/right.png" alt="" />
        <div class="sliders">
          <div class="slider-item">
            <div class="number">
              <p>01</p>
              <div class="number-line"></div>
            </div>
            <div class="portrait">
              <img src="../../public/photo2.png" alt="" />
            </div>
            <div class="info">
              <div class="name">
                <p>有声的子衿</p>
                <img class="vip" src="../../public/VIP.png" alt="" />
              </div>
              <div class="brief">人肉故事机。来呀，等你关注</div>
            </div>
          </div>
          <div class="slider-item">
            <div class="number">
              <p>01</p>
              <div class="number-line"></div>
            </div>
            <div class="portrait">
              <img src="../../public/photo2.png" alt="" />
            </div>
            <div class="info">
              <div class="name">
                <p>有声的子衿</p>
                <img class="vip" src="../../public/VIP.png" alt="" />
              </div>
              <div class="brief">人肉故事机。来呀，等你关注</div>
            </div>
          </div>
          <div class="slider-item">
            <div class="number">
              <p>01</p>
              <div class="number-line"></div>
            </div>
            <div class="portrait">
              <img src="../../public/photo2.png" alt="" />
            </div>
            <div class="info">
              <div class="name">
                <p>有声的子衿</p>
                <img class="vip" src="../../public/VIP.png" alt="" />
              </div>
              <div class="brief">人肉故事机。来呀，等你关注</div>
            </div>
          </div>
          <div class="slider-item">
            <div class="number">
              <p>01</p>
              <div class="number-line"></div>
            </div>
            <div class="portrait">
              <img src="../../public/photo2.png" alt="" />
            </div>
            <div class="info">
              <div class="name">
                <p>有声的子衿</p>
                <img class="vip" src="../../public/VIP.png" alt="" />
              </div>
              <div class="brief">人肉故事机。来呀，等你关注</div>
            </div>
          </div>
          <div class="slider-item">
            <div class="number">
              <p>01</p>
              <div class="number-line"></div>
            </div>
            <div class="portrait">
              <img src="../../public/photo2.png" alt="" />
            </div>
            <div class="info">
              <div class="name">
                <p>有声的子衿</p>
                <img class="vip" src="../../public/VIP.png" alt="" />
              </div>
              <div class="brief">人肉故事机。来呀，等你关注</div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div style="height: 50px"></div>
  </div>
</template>

<script>
// @ is an alias to /src
import axios from 'axios'
export default {
  name: "home",
  data(){
    return {
      list:[]
    }
  },
  methods:{
    getList(){
      const url = 'http://localhost:8080/biyesheji/audio/list'
      axios.get(url).then(res=>{
        console.log(res.data);
        this.list = res.data
      })
    }
  },
  mounted(){
    this.getList()
  },
  components: {

  },
};
</script>
 <style scoped>
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
  display: flex;
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
.slider {
  position: relative;
  width: 380px;
  border: 1px solid #ccc;
  padding: 0 20px;
}
.slider-item {
  position: relative;
  width: 100%;
  height: 100px;
  display: flex;
  align-items: center;
  border-bottom: 1px solid #ccc;
}
.slider-item:first-child {
  border-top: 2px solid #ccc;
}
.slider-title {
  font-size: 22px;
  font-weight: 500;
  margin-top: 12px;
  margin-bottom: 15px;
}
.more2 {
  position: absolute;
  right: 40px;
  top: 16px;
}
.more-icon {
  position: absolute;
  right: 20px;
  top: 20px;
  width: 14px;
  height: 14px;
}
.slider-item .number {
  font-size: 28px;
}
.slider-item .number-line {
  width: 32px;
  height: 2px;
  background-color: #ccc;
  margin-top: 8px;
}
.slider-item .portrait {
  margin-left: 20px;
}
.slider-item .portrait img {
  width: 80px;
  height: 80px;
  border-radius: 50%;
}
.slider-item .info {
  margin-left: 20px;
}
.slider-item .info .name {
  display: flex;
  font-size: 16px;
  font-weight: 600;
  align-items: center;
  margin-top: -10px;
}
.slider-item .info .brief {
  font-size: 12px;
  color: rgb(138, 137, 137);
}
.slider-item .vip {
  width: 40px;
  height: 38px;
}
</style>

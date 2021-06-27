<template>
  <div>
    <div class="search-container">
      <div class="search">
        <input type="text" />
        <div class="img">
          <img src="../../public/Search.png" alt="" />
        </div>
      </div>
      <div style="display: flex">
        <div class="results">
          <div class="result" v-for="(item,index) in resultList" :key="index">
            <img :src="item.imgUrl" alt="" />
            <div class="info">
              <p>{{item.name}}</p>
              <p><span>合集：</span>{{item.collection}}</p>
            </div>
            <p class="author"><span>by：</span>{{item.autor}}</p>
            <p class="time"><span>时长：</span>{{item.time}}</p>
            <img class="play" @click="toPlay" src="../../public/play.png" alt="" />
          </div>
        </div>
        <div class="rank-list">
          <div class="title">
            <img src="../../public/rank.png" alt="" />
            <p>每日热门</p>
          </div>
          <div class="lists">
            <div class="list">
              <img src="../../public/first.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/second.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/third.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/4.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/5.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/6.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/7.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/8.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/9.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
          </div>
          <div class="title title2">
            <img src="../../public/rank.png" alt="" />
            <p>最多人搜</p>
          </div>
          <div class="lists">
            <div class="list">
              <img src="../../public/first.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/second.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/third.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/4.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/5.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/6.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/7.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/8.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
            <div class="list">
              <img src="../../public/9.png" alt="" />
              <p>重生之我是UZI重生之我是UZI重生</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data(){
    return {
      resultList:[
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t14.baidu.com/it/u=77466239,3866616347&fm=224&app=112&f=JPEG?w=429&h=499&s=BCB00A9BD4074AEE1C3F946B0300B031',name:'宝葫芦的秘密',collection:'童话故事',autor:'黎明',time:'20:60'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        {imgUrl:'http://t13.baidu.com/it/u=209943214,4118715336&fm=224&app=112&f=JPEG?w=500&h=500',name:'乐器',collection:'童话故事',autor:'江南',time:'20:14'},
        ]
    }
  },
  methods:{
    toPlay(){
      this.$router.push('/player')
    }
  }
};
</script>

<style scoped>
.search-container {
  width: 1180px;
  border: 1px solid black;
  margin: 0 auto;
}
.search {
  width: 100%;
  height: 160px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.search input {
  width: 320px;
  height: 44px;
  padding-left: 20px;
  border-radius: 6px 0 0 6px;
  border: 1px solid #ccc;
  box-shadow: inset -2px 2px 2px #ccc;
  outline: none;
}
.search .img {
  width: 44px;
  height: 44px;
  background-color: #eee;
  border: 1px solid #ccc;
  text-align: center;
  cursor: pointer;
}
.search img {
  width: 32px;
  height: 32px;
  margin-top: 6px;
}
.results {
  width: 900px;
  border: 1px solid black;
  padding: 20px;
}
.result {
  width: 860px;
  height: 100px;
  border: 1px solid #ccc;
  display: flex;
  align-items: center;
  margin-bottom: 10px;
}
.result img {
  width: 100px;
  height: 100px;
}
.result .info {
  height: 100px;
  width: 200px;
  color: rgb(110, 109, 109);
  margin-left: 20px;
}
.result .info p:first-child {
  margin-top: 20px;
  font-size: 16px;
}
.result .info p:last-child {
  margin-top: 8px;
  font-size: 14px;
}
.result .author {
  margin-left: 150px;
  width: 160px;
  color: rgb(110, 109, 109);
}
.result .time {
  color: rgb(110, 109, 109);
  width: 100px;
}
.result .play {
  width: 60px;
  height: 60px;
  margin-left: 40px;
  cursor: pointer;
}
.rank-list {
  width: 280px;
  border: 1px solid black;
  padding: 0 20px;
}
.rank-list .title {
  width: 100%;
  height: 48px;
  display: flex;
  align-items: center;
  border-bottom: 1px solid #ccc;
}
.rank-list .title img {
  width: 24px;
  height: 24px;
  margin-right: 8px;
}
.rank-list .lists {
  margin-top: 20px;
}
.rank-list .list {
  height: 44px;
  display: flex;
  align-items: center;
  color: rgb(110, 109, 109);
}
.rank-list .list img {
  width: 32px;
  height: 32px;
}
.rank-list .list p {
  width: 200px;
  margin-left: 10px;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  font-size: 14px;
}
.rank-list .title2 {
    margin-top: 10px;
}
</style>>

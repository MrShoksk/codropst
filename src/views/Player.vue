<template>
  <div class="player-container">
    <div class="main">
      <!-- <button @click="toPlay">点击播放</button>
      <button @click="toPause">点击暂停</button> -->
      <!-- <button @click="change">切换</button> -->
      <!-- <button @click="play">切换</button> -->
      <div class="CD">
        <div class="CD-bg" :class="type === 2 ? 'circle' : ''">
          <img src="../../public/book.jpg" alt="" />
        </div>
        <div class="CD-info">
          <ul>
            <li style="font-size: 40px; list-style-type: none; margin-left: 0">
              蜗牛故事
            </li>
            <li>作者：有声的子衿</li>
            <li>合集：神话故事</li>
            <li>发布时间：2022-03-19</li>
            <li>评分：9.5</li>
          </ul>
        </div>
      </div>
      <div class="big-controls">
        <div class="controls">
          <img src="../../public/last.png" alt="" />
          <img
            @click="toPlay"
            v-if="type == 1"
            src="../../public/play2.png"
            alt=""
          />
          <img
            @click="toPause"
            v-if="type == 2"
            src="../../public/pause2.png"
            alt=""
          />
          <img src="../../public/next.png" alt="" />
        </div>
          <a href="" download="蜗牛故事.mp3"><img class="download" src="../../public/download.png" alt="" /></a>
      </div>
      <div class="comments">
        <div class="comments-title">
          <p>发表我的评论</p>
        </div>
        <div class="comments-content">
          <textarea
            name=""
            id=""
            cols="140"
            rows="3"
            style="outline: none; font-size: 14px"
            v-model="myComment"
          ></textarea>
          <button @click="publish">发表</button>
        </div>
        <div style="height: 14px"></div>
        <hr />
        <div class="comments-title">
          <p>全部评论(1w+)</p>
          <div class="comment" v-for="(i,n) in commentList" :key="n">
            <img :src="i.avarUrl" alt="" />
            <div class="comment-info">
              <p>
                <span>{{i.username}}：</span>{{i.content}}
              </p>
              <p>{{i.time}}</p>
            </div>
          </div>

        </div>
        <div></div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      type: 1,
      user: "mybbidh",
      commentList:[
        {username:'兰兰小白鹄',avarUrl:'https://img2.baidu.com/it/u=1742064249,2154824212&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=500',content:'我们都不是天赋异禀的人在茫茫人海中甚至会有些平庸 可是我们的人生不仅仅是潦草诗当在迷雾散尽时 天光大亮 我们一定会看清远方的灯塔奔走在漫漫时光中 成为故事的主角',time:'2020年2月20日 18:30'},
        {username:'时刻是蛊',avarUrl:'https://img0.baidu.com/it/u=1942253063,3807598283&fm=253&fmt=auto&app=138&f=JPEG?w=500&h=500',content:'有朝一日请想我。 -- 安德烈艾席蒙 《Call me by your name》',time:'2020年2月27日 18:30'},
        {username:'垂头的温柔',avarUrl:'https://img0.baidu.com/it/u=325674188,3280397254&fm=253&fmt=auto&app=138&f=JPEG?w=501&h=500',content:'为什么有些人性格很好却总是独来独往？因为性格好是教养，独来独往是性格。',time:'2020年2月30日 20:30'},
      ],
      myComment:''
    };
  },
  methods: {
    toPlay() {
      this.$parent.$refs.MusicPlay.play();
      this.type = 2;
      localStorage.setItem("type", this.type);
    },
    toPause() {
      this.$parent.$refs.MusicPlay.pause();
      this.type = 1;
      localStorage.setItem("type", this.type);
    },
    change() {
      console.log("logout child");
      this.$emit("logoutUser", this.user);
    },
    download() {
      this.$parent.$refs.MusicPlay.download();
    },
    play() {},
    publish(){
      console.log(this.myComment);
      const mine = {}
      if (this.myComment) {
        mine.username = '纳新'
      mine.avarUrl = 'http://mms0.baidu.com/it/u=2152357245,920666573&fm=253&app=120&f=JPEG&fmt=auto&q=75&fmt=auto&q=75?w=500&h=500'
      mine.content = this.myComment
      var myDate = new Date();
      mine.time = myDate.getFullYear()+'年'+(myDate.getMonth()+1)+'月'+myDate.getDate()+'日'+' '+myDate.getHours()+':'+myDate.getMinutes()
      this.commentList.push(mine)
      }
      
    }
  },
  mounted() {
    const nowType = localStorage.getItem("type");
    console.log(nowType);
    this.type = JSON.parse(nowType);
  },
};
</script>

<style scoped>
.main {
  width: 1180px;
  height: 600px;
  margin: 0 auto;
  border: 1px solid #ccc;
}
.CD {
  position: relative;
  width: 100%;
  height: 500px;
  padding-top: 50px;
}
.CD-bg {
  width: 400px;
  height: 400px;
  margin-top: 50px;
  background-color: #303132;
  border-radius: 50%;
  border: 20px solid #d3d3d3;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: center;
}
.circle {
  animation: circle 12s linear infinite;
}
.CD-bg img {
  width: 260px;
  height: 260px;
  border-radius: 50%;
}
@keyframes circle {
  0% {
    -webkit-transform: rotate(0deg);
  }
  25% {
    -webkit-transform: rotate(90deg);
  }
  50% {
    -webkit-transform: rotate(180deg);
  }
  75% {
    -webkit-transform: rotate(270deg);
  }
  100% {
    -webkit-transform: rotate(360deg);
  }
}
.controls {
  width: 400px;
  height: 100px;
  margin: 0 auto;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.controls img {
  cursor: pointer;
}
.big-controls {
  position: relative;
}
.download {
  position: absolute;
  top: 28px;
  right: 100px;
}
.CD-info {
  position: absolute;
  top: 100px;
  right: 50px;
}
.CD-info ul li {
  margin-left: 16px;
  margin-top: 8px;
  color: #535455;
}
.comments {
  border: 1px solid #ccc;
  padding: 20px 100px;
}
.comments-title p {
  font-size: 18px;
  font-weight: 600;
}
.comments-content {
  display: flex;
  margin-top: 20px;
}

.comments-content button {
  width: 60px;
  height: 40px;
  color: white;
  background-color: rgb(97, 94, 94);
  border: none;
  margin-top: 40px;
  margin-left: 20px;
  cursor: pointer;
}
.comment {
  height: 80px;
  border-bottom: 1px solid rgb(207, 206, 206);
  display: flex;
  align-items: center;
}
.comment img {
  width: 48px;
  height: 48px;
  border-radius: 50%;
}
.comment-info {
  margin-left: 10px;
}
.comment-info p {
  font-size: 12px;
  color: #535455;
  font-weight: 400;
}
.comment-info span {
  font-size: 14px;
  color: rgb(80, 133, 177);
}
.comment-info p:last-child {
  margin-top: 6px;
  color: #ccc;
}
</style>> 

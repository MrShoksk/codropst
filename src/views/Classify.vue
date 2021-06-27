<template>
  <div class="classify-container">
    <div class="top">
      <div class="option" @click="pingshu1">评书</div>
      <div class="option" @click="xiangsheng1">相声</div>
      <div class="option" @click="xiaopin1">小品</div>
      <div class="option">诗词</div>
      <div class="option">散文</div>
      <div class="option">有声小说</div>
      <div class="option">历史小说</div>
      <div class="option">儿童故事</div>
      <div class="option" @click='all'>其他</div>
    </div>
    <div class="main">
      <div class="title">全部作品</div>
      <div class="items">
        <div class="item" v-for="(i,j) in showingList" :key="j">
          <img :src="i.imgUrl" alt="" />
          <p>{{i.name}}</p>
          <p class="brief">{{i.info}}</p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      showingList: [],
      pingshu: [
        {
          imgUrl:
            "https://imagev2.xmcdn.com/storages/f962-audiofreehighqps/D3/57/GMCoOSUFh1yoAAICLwEAQjMm.png!strip=1&quality=7&magick=webp&op_type=3&columns=290&rows=290",
          name: "白眉大侠",
          info: "单田芳评书",
        },
        {
          imgUrl:
            "https://imagev2.xmcdn.com/storages/2f75-audiofreehighqps/36/AA/GMCoOSYFfkXSABTh4gD9zE1U.png!strip=1&quality=7&magick=webp&op_type=3&columns=290&rows=290",
          name: "小五义",
          info: "单田芳评书",
        },
        {
          imgUrl:
            "https://imagev2.xmcdn.com/group75/M04/42/24/wKgO016NaPGS_q5LAAKe2JheTYQ047.jpg!strip=1&quality=7&magick=webp&op_type=3&columns=290&rows=290",
          name: "薛家将",
          info: "单田芳评书",
        },
      ],
      xiangsheng:[
        {
          imgUrl:
            "https://imagev2.xmcdn.com/storages/a9ee-audiofreehighqps/5E/71/GKwRIUEGNXjFAAIUIwE_1QYr.jpg!strip=1&quality=7&magick=webp&op_type=3&columns=290&rows=290",
          name: "德云社小园子相声",
          info: "德云社郭德纲相声",
        },
        {
          imgUrl:
            "https://imagev2.xmcdn.com/storages/65a4-audiofreehighqps/D4/CB/CMCoOSED0WmDAAIljQB6U7L7!magick=webp",
          name: "听相声学成语",
          info: "嘉庆说故事",
        },
        {
          imgUrl:
            "https://imagev2.xmcdn.com/group32/M09/6A/27/wKgJS1mc4NHDwOJdAAA0-V79AqU370.jpg!strip=1&quality=7&magick=webp&op_type=3&columns=290&rows=290",
          name: "刘宝瑞相声全集",
          info: "相声爱好者",
        },
      ],
      xiaopin:[
        {
          imgUrl:
            "https://imagev2.xmcdn.com/group71/M02/8D/DC/wKgO2V4sxWLwZoW4AADolviru58649.jpg!strip=1&quality=7&magick=webp&op_type=5&upload_type=cover&name=web_large&device_type=ios",
          name: "沈腾爆笑小品全集",
          info: "by：忽而今夏丶7",
        },
        {
          imgUrl:'https://imagev2.xmcdn.com/storages/8f8a-audiofreehighqps/57/B2/CMCoOSADi7NCAACR-ABocTBK.jpg!strip=1&quality=7&magick=webp&op_type=5&upload_type=cover&name=web_large&device_type=ios',
          name: "春晚小品合辑",
          info: "by：毛小乖_",
        },
        {
          imgUrl:
            "https://imagev2.xmcdn.com/storages/6e16-audiofreehighqps/0C/79/CMCoOSUD3vLSAAK1awB-HzVL.jpeg!strip=1&quality=7&magick=webp&op_type=5&upload_type=cover&name=web_large&device_type=ios",
          name: "历年央视春晚相声小品",
          info: "by：央视专区",
        },
      ],
    };
  },
  methods: {
    getList() {},
    pingshu1(){
        this.showingList = this.pingshu
    },
    xiangsheng1(){
        this.showingList = this.xiangsheng
    },
    xiaopin1(){
        this.showingList = this.xiaopin
    },
    all(){
      this.showingList = [...this.pingshu,...this.xiangsheng,...this.xiaopin,...this.pingshu,...this.xiaopin]
    }
  },
  mounted(){
      this.all()
  }
};
</script>

<style lang="less" scoped>
.classify-container {
  width: 1180px;
  margin: 0 auto;
}
.top {
  height: 140px;
  background-color: rgb(238, 238, 238);
  box-shadow: 2px 2px 2px #ccc;
  display: flex;
  flex-wrap: wrap;
  padding-bottom: 20px;
  .option {
    margin-top: 20px;
    width: 120px;
    background-color: rgb(219, 216, 216);
    height: 32px;
    border-radius: 16px;
    text-align: center;
    line-height: 32px;
    margin-left: 50px;
    cursor: pointer;
  }
}
.main {
  margin-top: 10px;
  background-color: rgb(238, 238, 238);
  box-shadow: 2px 2px 2px #ccc;
  padding: 0 20px;
  padding-bottom: 20px;
  .title {
    height: 44px;
    font-size: 20px;
    display: flex;
    align-items: center;
    border-bottom: 1px solid #000;
  }
  .items {
    display: flex;
    flex-wrap: wrap;
    margin-top: 20px;
    .item {
      width: 166px;
      height: 240px;
      margin-left: 20px;
      img {
        width: 100%;
        height: 180px;
        border-radius: 6px;
      }
      .brief {
        color: rgb(160, 160, 160);
        margin-top: 6px;
        font-size: 13px;
      }
    }
  }
}
</style>

<template>
  <div class="classify-container">
      <div class="top">
          <div class="option">评书</div>
          <div class="option">相声</div>
          <div class="option">小品</div>
          <div class="option">诗词</div>
          <div class="option">散文</div>
          <div class="option">有声小说</div>
          <div class="option">历史小说</div>
          <div class="option">儿童故事</div>
          <div class="option">其他</div>
      </div>
      <div class="main">
          <div class="title">全部作品</div>
          <div class="items">
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
              <div class="item">
                  <img src="../../public/book.jpg" alt="">
                  <p>此处最多十个字安安啊</p>
                  <p class="brief">此处最多十二个字啊啊啊啊</p>
              </div>
          </div>
      </div>
  </div>
</template>

<script>
export default {

}
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

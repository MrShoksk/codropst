<template>
  <div class="player-container">
    <div>
      <button @click="toPlay">点击播放</button>
      <button @click="toPause">点击暂停</button>
      <button @click="change">切换</button>
      <button @click="play">切换</button>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      user: "mybbidh",
    };
  },
  methods: {
    toPlay() {
      this.$parent.$refs.MusicPlay.play();
    },
    toPause() {
      this.$parent.$refs.MusicPlay.pause();
    },
    change() {
      console.log("logout child");
      this.$emit("logoutUser", this.user);
    },
    play(){

    }
  },
};
</script>

<style scoped>
.player {
  width: 600px;
  height: 60px;
}
</style>> 

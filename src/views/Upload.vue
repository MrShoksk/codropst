<template>
  <div class="upload-container">
    <div class="upload-form">
      <el-form ref="form" :model="form" label-width="80px">
        <el-form-item label="作品名称">
          <el-input v-model="form.name"></el-input>
        </el-form-item>
        <el-form-item label="作品类型">
          <el-select v-model="form.region" placeholder="请选择活动区域">
            <el-option label="评书" value="pingshu"></el-option>
            <el-option label="相声" value="xiangsheng"></el-option>
            <el-option label="小品" value="xiaopin"></el-option>
            <el-option label="诗词" value="shici"></el-option>
          </el-select>
        </el-form-item>
        <el-form-item label="活动时间">
          <el-col :span="11">
            <el-date-picker
              type="date"
              placeholder="选择日期"
              v-model="form.date1"
              style="width: 100%"
            ></el-date-picker>
          </el-col>
          <el-col class="line" :span="2">-</el-col>
          <el-col :span="11">
            <el-time-picker
              placeholder="选择时间"
              v-model="form.date2"
              style="width: 100%"
            ></el-time-picker>
          </el-col>
        </el-form-item>
        <el-form-item label="即时配送">
          <el-switch v-model="form.delivery"></el-switch>
        </el-form-item>

        <el-form-item label="合集">
          <el-radio-group v-model="form.resource">
            <el-radio label="我的诗歌"></el-radio>
            <el-radio label="我的歌词"></el-radio>
          </el-radio-group>
        </el-form-item>
        <el-form-item label="作品简介">
          <el-input type="textarea" v-model="form.desc"></el-input>
        </el-form-item>
        <el-form-item>
          <el-button type="primary" @click="onSubmit">立即创建</el-button>
          <el-button>取消</el-button>
        </el-form-item>
      </el-form>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      form: {
        name: "",
        region: "",
        date1: "",
        date2: "",
        delivery: false,
        type: [],
        resource: "",
        desc: "",
      },
    };
  },
  methods: {
    onSubmit() {
      console.log("submit!");
    },
  },
};
</script>

<style lang="less" scoped>
.upload-container {
  width: 1180px;
  margin: 0 auto;
  background-color: #fff;
  padding: 100px 0;
  .upload-form {
    width: 600px;
    margin:auto;
  }
}
</style>
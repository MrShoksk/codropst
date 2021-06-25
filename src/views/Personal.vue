<template>
  <div class="personal-container">
    <div class="main">
      <div class="title">作者中心</div>
      <div class="parts" v-if="type == 2">
        <div class="part">
          <img src="../../public/music.png" alt="" />
          <p>录制作品</p>
          <p>说出你的故事</p>
        </div>
        <div class="part">
          <img src="../../public/up.png" alt="" />
          <p>上传作品</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part">
          <img src="../../public/mine.png" alt="" />
          <p>我的作品</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part" style="opacti">
          <img src="../../public/setting.png" alt="" />
          <p>账号设置</p>
          <p>让别人听见你的声音</p>
        </div>
        <div class="part" style="opacity: 0"></div>
        <div class="part" style="opacity: 0"></div>
      </div>
      <div v-if="type == 1">
        <el-form
          :model="userInp"
          ref="ruleForm"
          label-width="100px"
          class="demo-ruleForm"
        >
          <el-form-item label="用户名" prop="name">
            <el-input v-model="userInp.name"></el-input>
          </el-form-item>
          <el-form-item label="密码" prop="pass">
            <el-input
              type="password"
              v-model="userInp.pass"
              autocomplete="off"
            ></el-input>
          </el-form-item>
          <el-button type="info" plain @click="check">点击登录</el-button>
          <el-link type="info" @click="type=3">没有账号？前去注册</el-link>
        </el-form>
      </div>
      <div v-if="type == 3">
        <el-form
          :model="ruleForm"
          :rules="rules"
          ref="ruleForm"
          label-width="100px"
          class="demo-ruleForm"
        >
          <el-form-item label="活动名称" prop="name">
            <el-input v-model="ruleForm.name"></el-input>
          </el-form-item>
          <el-form-item label="密码" prop="pass">
            <el-input
              type="password"
              v-model="ruleForm.pass"
              autocomplete="off"
            ></el-input>
          </el-form-item>
          <el-form-item label="确认密码" prop="checkPass">
            <el-input
              type="password"
              v-model="ruleForm.checkPass"
              autocomplete="off"
            ></el-input>
          </el-form-item>
          <el-button type="info" plain>点击注册</el-button>
          <el-link @click="type=1" type="info">已有账号，前去登录</el-link>
        </el-form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props:['typen'],
  data() {
    var validateName = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请输入用户名"));
      } else {
        callback();
      }
    };
    var validatePass = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请输入密码"));
      } else {
        if (this.ruleForm.checkPass !== "") {
          this.$refs.ruleForm.validateField("checkPass");
        }
        callback();
      }
    };
    var validatePass2 = (rule, value, callback) => {
      if (value === "") {
        callback(new Error("请再次输入密码"));
      } else if (value !== this.ruleForm.pass) {
        callback(new Error("两次输入密码不一致!"));
      } else {
        callback();
      }
    };
    return {
      type: 1,
      userInp: {
        name: "",
        pass: "",
      },
      ruleForm: {
        name: "",
        pass: "",
        checkPass: "",
      },
      rules: {
        name: [{ validator: validateName, trigger: "blur" }],
        pass: [{ validator: validatePass, trigger: "blur" }],
        checkPass: [{ validator: validatePass2, trigger: "blur" }],
      },
    };
  },
  methods: {
    check() {
      if (this.userInp.name == "admin" && this.userInp.pass == "admin") {
        this.type = 2;
        this.open2();
        localStorage.setItem("userInfo", {
          username: this.userInp.name,
          password: this.userInp.pass,
        });
      }
    },
    open2() {
      this.$message({
        message: "登录成功",
        type: "success",
      });
    },
  },
  mounted() {
    const userInfo = localStorage.getItem('userInfo')
    if(userInfo){
      this.type = 2
    }else{
      this.type = this.typen
    }
    
  },
};
</script>

<style scoped>
.main {
  width: 1180px;
  height: 600px;
  margin: 0 auto;
}
.main .title {
  font-size: 44px;
  font-family: "Yu Gothic Light";
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
  cursor: pointer;
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
.el-input {
  width: 300px;
}
.el-form {
  margin-top: 100px;
  margin-left: 300px;
}
.el-button {
  margin-left: 100px;
}
.el-link {
  margin-left: 20px;
}
</style>
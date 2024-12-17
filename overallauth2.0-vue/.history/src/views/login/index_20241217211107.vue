<template>
  <div class="login-container">
    <div class="Login">
      <span>
        <h2>欢迎登录</h2>
      </span>
      <div class="Login-item">
        <el-input
              v-model="loginForm.UserName"
              style="width: 80%; height: 40px"
              clearable
              placeholder="请输入用户名"
              :prefix-icon="User"
            />
      </div>
      <div class="Login-item">
        <el-input
              v-model="loginForm.Password"
              style="width: 80%; height: 40px"
              clearable
              placeholder="请输入密码"
              type="password"
              show-password
              :prefix-icon="Hide"
            />
      </div>
      <div class="Login-item">
        <el-button
              @click="loginClick"
              type="primary"
              style="width: 80%; height: 50px"
              >登录</el-button
            >
      </div>
    </div>
  </div>
</template>
<script lang="ts" setup>
import { User, Hide } from '@element-plus/icons-vue';
import { reactive } from 'vue';


const loginForm = reactive({
  UserName: 'admin',
  Password: '123456',
})


function loginClick() {
  
}
</script>
<style >
.login-container {
  background-image: url(../../assets/picture/login.png);
  height: calc(100vh);
  width: 100%;
  background-size: 100% 100%;
  display: flex;
  background-color: rgba(0, 0, 0, 0.5); /* 半透明的背景 */
  position: relative; /* 为了让 z-index 生效 */
}
.Login {
  width: 400px;
  height: 300px;
  margin: 0 auto;
  margin-top: 200px;
  border: 1px solid #ccc;
  border-radius: 10px;
  padding: 20px;
  box-shadow: 0 0 10px #ccc;
  z-index: 9;
}
.Login-item {
  margin-top: 20px;
}
</style>
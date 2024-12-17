<template>
  <div>
    <div class="Login">
      <span>
        <h2>欢迎登录</h2>
      </span>
      <div>
        <el-input
              v-model="loginForm.UserName"
              style="width: 80%; height: 40px"
              clearable
              placeholder="请输入用户名"
              :prefix-icon="User"
            />
      </div>
      <div>
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
      <div>
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
.Login {
  width: 400px;
  height: 300px;
  margin: 20 auto;
  margin-top: 200px;
  border: 1px solid #ccc;
  border-radius: 10px;
  padding: 20px;
  box-shadow: 0 0 10px #ccc;
  
}
</style>
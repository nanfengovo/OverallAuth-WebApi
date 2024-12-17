<template>
  <div>
    <div>
      <span>
        <h2>欢迎登录</h2>
      </span>
      <div>
        <el-input
              v-model="loginForm.UserName"
              style="width: 80%; height: 40px"
              placeholder="请输入用户名"
              :prefix-icon="User"
            />
      </div>
      <div>
        <el-input
              v-model="loginForm.Password"
              style="width: 80%; height: 40px"
              placeholder="请输入密码"
              type="password"
              show-password
              :prefix-icon="Hide"
            />
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
</script>
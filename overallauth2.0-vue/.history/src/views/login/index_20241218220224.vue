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
              :prefix-icon="Lock"
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
<script lang="ts">
import { defineComponent, onMounted, reactive, ref } from "vue";
import { TestAutofac } from "../../api/module/user";
import { User, Hide, Position, StarFilled } from "@element-plus/icons-vue";
import { ElMessage } from "element-plus";
import { useRouter } from "vue-router";
import { login } from "@/api/user";
import { LoginInput } from "@/model/user/LoginInput";
import { useUserStore } from "../../store/user";
import { storeToRefs } from "pinia";
import { fa } from "element-plus/es/locale";
export default defineComponent({
  setup() {
    //初始加载
    onMounted(() => {
      //TestAutofacMsg();
    });
    const userStore = useUserStore();
    const loading = ref(false);
    const router = useRouter();
    const userName = ref("");
    const password = ref("");
    const code = ref("");
    const isStarted = ref<boolean>(false);
    //调用接口
    const TestAutofacMsg = async () => {
      var result = await TestAutofac();
      console.log(result);
    };

    const loginForm = reactive<LoginInput>({
      UserName: "张三",
      Password: "1",
    });
    const loginClick = function () {
      loading.value = true;
      login(loginForm).then(({ data, code, msg }) => {
        setTimeout(async () => {
          if (code == 200) {
            userStore.token = data[0].token.toString();
            userStore.expiresDate = data[0].expiresDate;
            userStore.userInfo = {
              userName: data[0].userName,
              userId: data[0].userId,
            };
            await userStore.loadMenus();
            ElMessage({
              message: "登录成功",
              type: "success",
            });
            router.push("/panel");
          }
          loading.value = false;
        }, 1000);
      });
    };

    return {
      User,
      Hide,
      Position,
      StarFilled,
      userName,
      password,
      code,
      isStarted,
      loginClick,
      loginForm,
      loading,
    };
  },
  components: {},
});
</script>
<style >
.login-container {
  background-image: url(../../assets/picture/login.png);
  height: calc(100vh);
  width: 100%;
  background-size: 100% 100%;
  display: flex;

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
  
}
.Login-item {
  margin-top: 20px;
}
</style>
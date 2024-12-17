<template>
  <div class="backgroundStyle">
    <div class="loginStyle">
      <div style="color: rgb(76 104 139)">
        <div class="systemTitle">
          OverallAuth2.0 权限管理系统
        </div>
        <div class="systemSubTitle">
          简单、易懂、功能强大，欢迎访问使用。
        </div>
      </div>
      <div style="height: calc(100% - 260px)">
        <div class="fieldStyle">
          <div style="width: 100%; text-align: left; margin-left: 10%">
            <el-tag>密码登录</el-tag>
          </div>
        </div>
        <div class="fieldStyle">
          <div style="width: 100%">
            <el-input
              v-model="loginForm.UserName"
              style="width: 80%; height: 40px"
              placeholder="请输入用户名"
              :prefix-icon="User"
            />
          </div>
        </div>
        <div class="fieldStyle">
          <div style="width: 100%">
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
        <div class="fieldStyle">
          <div style="width: 100%">
            <el-input
              v-model="code"
              style="width: 80%; height: 40px"
              placeholder="请输入验证码"
              :prefix-icon="Position"
            />
          </div>
        </div>
        <div class="fieldStyle">
          <div style="width: 100%">
            <el-button
              @click="loginClick"
              type="primary"
              style="width: 80%; height: 50px"
              >登录</el-button
            >
          </div>
        </div>
      </div>
      <div style="height: 60px; text-align: left; margin-left: 10px">
        <el-checkbox v-model="isStarted" label="码云是否Star" size="large" />
        <div style="color: red; font-size: 12px">
          *为了帮助更多的人知道及了解本项目,请帮忙Star。拜谢各位🙏🙏🙏
        </div>
      </div>
      <div class="loginBottomStyle">
        <el-divider content-position="left"
          ><el-icon color="red"><star-filled /></el-icon>特色功能</el-divider
        >
        <div class="featuresFunction">
          <el-tag>可视化权限设计</el-tag>
          <el-tag type="success">数据行权限</el-tag>
          <el-tag type="warning">数据列权限</el-tag>
          <el-tag type="danger">完整流程审批</el-tag>
        </div>
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
export default defineComponent({
  setup() {
    //初始加载
    onMounted(() => {
      //TestAutofacMsg();
    });
    const userStore = useUserStore();
    
    const router1 = useRouter();
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
      login(loginForm).then(({ data, code, msg }) => {
        setTimeout(() => {
          if (code == 200) {
            userStore.token = data[0].token.toString();
            userStore.expiresDate = data[0].expiresDate;
            userStore.userInfo = {
              userName: data[0].userName,
              userId: data[0].userId,
            };

            ElMessage({
              message: "登录成功",
              type: "success",
            });
            router1.push({ path: "/framework" });
          }
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
    };
  },
  components: {},
});
</script>

<style scoped>
.backgroundStyle {
  background-image: url(../../assets/picture/login.png);
  height: calc(100vh);
  width: 100%;
  background-size: 100% 100%;
  display: flex;
}

.loginStyle {
  width: 23%;
  height: 55%;
  margin-top: 12%;
  margin-left: 10%;
  border: 2px solid white;
  background-color: white;
  border-radius: 10px;
  box-shadow: 0px 0px 19px 0px rgba(132, 203, 255, 2.5);
}
.systemTitle {
  height: 70px;
  font-size: 30px;
  justify-content: center;
  align-items: center;
  display: flex;
}
.systemSubTitle {
  display: flex;
  height: 30px;
  font-size: 14px;
  justify-content: center;
  border-bottom: 1px solid #e1dede;
}

.loginBottomStyle {
  height: 100px;
  /* font-size: 30px; */
  justify-content: center;
  align-items: center;
}

.fieldStyle {
  display: flex;
  margin-top: 10px;
}

.featuresFunction {
  display: flex;
}
.featuresFunction > * {
  margin-left: 10px;
}
</style>
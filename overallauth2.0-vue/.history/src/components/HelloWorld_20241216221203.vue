<template>
  <div style="height: calc(100vh); overflow: hidden">
    <el-container style="height: 100%; overflow: hidden">
      <el-aside width="auto">
        <el-menu
          class="el-menu-vertical-demo"
          background-color="#545c64"
          text-color="#fff"
          active-text-color="#ffd04b"
          style="height: 100%"
        >
        <div class="el-menu-box">
            <div
              class="logo-image"
              style="width: 18px; height: 18px; background-size: 18px 18px"
            ></div>
            <div style="padding-left: 5px; padding-top: 7px">
              OverallAuth2.0
            </div>
          </div>
          <el-sub-menu index="1">
            <template #title>
              <el-icon><location /></el-icon>
              <span>Navigator One</span>
            </template>
            <el-menu-item-group title="Group One">
              <el-menu-item index="1-1">item one</el-menu-item>
              <el-menu-item index="1-2">item two</el-menu-item>
            </el-menu-item-group>
            <el-menu-item-group title="Group Two">
              <el-menu-item index="1-3">item three</el-menu-item>
            </el-menu-item-group>
            <el-sub-menu index="1-4">
              <template #title>item four</template>
              <el-menu-item index="1-4-1">item one</el-menu-item>
            </el-sub-menu>
          </el-sub-menu>
          <el-menu-item index="2">
            <el-icon><icon-menu /></el-icon>
            <span>Navigator Two</span>
          </el-menu-item>
          <el-menu-item index="3" disabled>
            <el-icon><document /></el-icon>
            <span>Navigator Three</span>
          </el-menu-item>
          <el-menu-item index="4">
            <el-icon><setting /></el-icon>
            <span>Navigator Four</span>
          </el-menu-item>
        </el-menu>
      </el-aside>

      <el-container>
        <el-header class="headerCss">
          <div style="display: flex; height: 100%; align-items: center">
            <div
              style="
                text-align: left;
                width: 50%;
                font-size: 18px;
                display: flex;
              "
            >
              <div class="logo-image" style="width: 32px; height: 32px"></div>
              <div style="padding-left: 10px; padding-top: 7px">
                OverallAuth2.0 权限管理系统
              </div>
            </div>
            <div
              style="
                text-align: right;
                width: 50%;
                display: flex;
                justify-content: right;
                cursor: pointer;
              "
            >
              <div
                class="user-image"
                style="width: 22px; height: 22px; background-size: 22px 22px"
              ></div>
              <div style="padding-left: 5px; padding-top: 3px">王小虎</div>
            </div>
          </div>
        </el-header>

        <el-main class="el-main">
          欢迎
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  setup() {},
  components: {},
});
</script>

<style scoped>
.el-menu-vertical-demo:not(.el-menu--collapse) {
  width: 200px;
  min-height: 400px;
}
.el-menu-box {
  display: flex;
  padding-left: 25px;
  align-items: center;
  height: 57px;
  box-shadow: 0 1px 4px #00152914;
  border: 1px solid #00152914;
  color: white;
}
.el-main {
  padding-top: 0px;
  padding-left: 1px;
  padding-right: 1px;
  margin: 0;
}
.headerCss {
  font-size: 12px;
  border: 1px solid #00152914;
  box-shadow: 0 1px 4px #00152914;
  justify-content: right;
  align-items: center;
  /* display: flex; */
}
.logo-image {
  background-image: url("../components/权限分配.png");
}
.user-image {
  background-image: url("../components/用户.png");
}
.demo-tabs /deep/ .el-tabs__header {
  color: #333; /* 标签页头部字体颜色 */
  margin: 0 0 5px !important;
}
.demo-tabs /deep/ .el-tabs__nav-wrap {
  padding-left: 10px;
}
</style>

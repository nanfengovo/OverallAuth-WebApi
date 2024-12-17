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
          router
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
          <div v-for="menuItem in menu" :key="menuItem.path">
            <el-sub-menu
              v-if="menuItem.children && menuItem.children.length"
              :index="menuItem.path"
              :key="menuItem.name"
            >
              <template #title>
                <el-icon><location /></el-icon>{{ menuItem.name }}</template
              >
              <el-menu-item
                v-for="subMenuItem in menuItem.children"
                :index="subMenuItem.path"
                :route="{ name: subMenuItem.name }"
                :key="subMenuItem.name"
                style="cursor: pointer"
              >
                {{ subMenuItem.name }}
              </el-menu-item>
            </el-sub-menu>

            <el-menu-item
              v-else
              :index="menuItem.path"
              :key="menuItem.path"
              :route="{ name: menuItem.name }"
              style="cursor: pointer"
            >
              {{ menuItem.name }}
            </el-menu-item>
          </div>
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
              <div style="padding-left: 5px; padding-top: 3px">
                微信公众号：不只是码农
              </div>
            </div>
          </div>
        </el-header>

        <el-main>
          <router-view></router-view>
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>
/* eslint-disable */
<script lang="ts">
import { defineComponent, ref } from "vue";
import { routes } from "../router/module/base-routes";

export default defineComponent({
  setup() {
    const menu = routes;
    return {
      menu,
    };
  },
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

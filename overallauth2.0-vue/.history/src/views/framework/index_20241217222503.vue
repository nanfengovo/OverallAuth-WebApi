<template>
  <div style="height: calc(100vh); overflow: hidden">
    <el-container style="height: 100%; overflow: hidden">
      <el-aside width="auto">
        <el-menu
          :default-active="defaultActive"
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
            />
            <div style="padding-left: 5px; padding-top: 7px">
              OverallAuth2.0
            </div>
          </div>
          <div
            v-for="menuItem in menu"
            :key="menuItem.path"
          >
            <el-sub-menu
              v-if="menuItem.children && menuItem.children.length"
              :key="menuItem.name"
              :index="menuItem.path"
            >
              <template #title>
                <el-icon><location /></el-icon>{{ menuItem.name }}
              </template>
              <el-menu-item
                v-for="subMenuItem in menuItem.children"
                :key="subMenuItem.name"
                :index="subMenuItem.path"
                :route="{ name: subMenuItem.name }"
                style="cursor: pointer"
                @click="menuItemClick(subMenuItem)"
              >
                {{ subMenuItem.name }}
              </el-menu-item>
            </el-sub-menu>
    
            <el-menu-item
              v-else
              :key="menuItem.path"
              :index="menuItem.path"
              :route="{ name: menuItem.name }"
              style="cursor: pointer"
              @click="menuItemClick(menuItem)"
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
              <div
                class="logo-image"
                style="width: 32px; height: 32px"
              />
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
              />
              <div style="padding-left: 5px; padding-top: 3px">
                微信公众号：不只是码农
              </div>
            </div>
          </div>
        </el-header>
    
        <el-main>
          <el-tabs
            v-if="tabsList.length > 0"
            v-model="defaultActive"
            class="demo-tabs"
            @click="tabsClick(defaultActive)"
            @tab-remove="tabRemoveClick"
          >
            <el-tab-pane
              v-for="item in tabsList"
              :key="item.path"
              :label="item.name"
              :name="item.path"
              :closable="item.path == '/panel' ? false : true"
              style="font-size: 16px"
            >
              <router-view />
            </el-tab-pane>
          </el-tabs>
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>
    
    <script lang="ts">
    import { defineComponent, onMounted, ref } from "vue";
    import  { routes } from "../../router/module/base-routes"; 
    import router from "../../router/index";
    import { RouteRecordRaw } from "vue-router";
    import { useUserStore } from "@/store/user";
    
    export default defineComponent({
        components: {},
        setup() {
        const userStore = useUserStore();
        const defaultActive = ref("/panel");
        const excludePaths = ["/framework", "/login"];

        const menu = userStore.menus.filter(
          (f: { path: string }) => !excludePaths.includes(f.path)
        );

        const tabsList = ref<RouteRecordRaw[]>([]);
        
        //初始加载dom
        onMounted(() => {
            tabsList.value.push(routes[0]); //默认打开第一个标签
            router.push(routes[0]); 
        });
        //菜单项点击事件
        function menuItemClick(subMenuItem: RouteRecordRaw) {
            // tabList中不存在则追加
            if (!tabsList.value.some((sub) => sub.path == subMenuItem.path)) {
            tabsList.value.push(subMenuItem);
            }
            defaultActive.value = subMenuItem.path;
        }
    
        //菜单标签点击事件
        const tabsClick = (item: string) => {
            defaultActive.value = item;
            router.push({ path: item });
        };
    
        //菜单标签移除事件
        const tabRemoveClick = (path: any) => {
            tabsList.value.map((item: { path: string }, index: any) => {
            if (item.path == path) tabsList.value.splice(index, 1); //index 当前元素索引；1：需要删除的元素个数
            });
            defaultActive.value = "/panel";
            router.push({ path: "/panel" });
        };
        return {
            menu,
            tabsList,
            defaultActive,
            tabsClick,
            tabRemoveClick,
            menuItemClick,
        };
        },
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
        background-image: url("../../assets/picture/权限分配.png");
    }
    .user-image {
        background-image: url("../../assets/picture/用户.png");
    }
    .demo-tabs /deep/ .el-tabs__header {
        color: #333; /* 标签页头部字体颜色 */
        margin: 0 0 5px !important;
    }
    .demo-tabs /deep/ .el-tabs__nav-wrap {
        padding-left: 10px;
    }
    </style>
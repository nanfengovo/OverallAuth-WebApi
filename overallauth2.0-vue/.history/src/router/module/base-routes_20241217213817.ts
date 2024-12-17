    import { createRouter, createWebHashHistory, RouteRecordRaw } from 'vue-router';
    import Panel from '../../views/panel/index.vue';
    import Login from '../../views/login/index.vue';
    import Framework from '../../views/framework/index.vue';

    export const routes: RouteRecordRaw[] = [];

    routes.push(
        {
          path: '/framework',
          component: frameWork,
          name: "架构",
      
        },
        {
          path: '/login',
          component: Login,
          name: "登录页面",
        },
        {
          path: '/panel',
          redirect: '/panel/index',
          meta: { title: '工作空间' },
          name: "工作空间",
          component: frameWork,
          children: [
            {
              path: '/panel',
              name: '工作台',
              component: () => import('../../views/panel/index.vue'),
              meta: { title: '工作台', requireAuth: true, affix: true, closable: false },
            }
          ]
        },
        {
          path: '/menu',
          redirect: '/menu/index',
          meta: { title: '菜单管理' },
          name: "菜单管理",
          component: Framework,
          children: [
            {
              path: '/menu',
              name: '菜单',
              component: () => import('../../views/menu/index.vue'),
              meta: { title: '菜单', requireAuth: true, affix: true, closable: false },
            }
          ]
        },
        {
          path: '/user',
          meta: { title: '用户管理' },
          name: "用户管理",
          component: FrameWork,
          children: [
            {
              path: '/user',
              name: '用户',
              component: () => import('../../views/user/index.vue'),
              meta: { title: '用户' },
            }]
        },
      )


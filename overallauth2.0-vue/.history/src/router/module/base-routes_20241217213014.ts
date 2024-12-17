    import { createRouter, createWebHashHistory, RouteRecordRaw } from 'vue-router';
    import Panel from '../../views/panel/index.vue';
    import Login from '../../views/login/index.vue';
    import Framework from '../../views/framework/index.vue';

    export const routes: RouteRecordRaw[] = [];

    routes.push(
    {
        path: '/framework',
        component: Framework,
        name: "架构",
        children:[
            {
                path: '/menu',
                redirect: '/menu/index',
                meta: { title: '菜单管理' },
                name: "菜单管理",
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
                children: [
                {
                    path: '/user',
                    name: '用户',
                    component: () => import('../../views/user/index.vue'),
                    meta: { title: '用户' },
                }]
            },
        ]
    
    },
    {
        path: '/login',
        component: Login,
        name: "登录页面",
    },
    {
        path: '/panel',
        component: Panel,
        name: "面板",
    },
   
    )


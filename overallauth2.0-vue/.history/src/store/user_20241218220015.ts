    import { getMenuTreeData } from '@/api/menu';
    import router from '@/router';
    import { ElMessage } from 'element-plus';
    import { defineStore } from 'pinia'
    import { ref } from 'vue';
    import { RouteRecordRaw } from 'vue-router';
    export const useUserStore = defineStore(
    'user', {
    state: () => ({
        token: '',
        expiresDate: '',
        userInfo: {},
        menus: [] as any,
    }),

    actions: {
        //获取菜单数据，并递归实现动态路由菜单
        async loadMenus() {
        new Promise<any>(async (resolve, reject) => {
            const { data, code, msg } = await getMenuTreeData();
            if (code == 200) {
            this.menus = data;
            const menuList = setMenuData(data) as RouteRecordRaw[]
            menuList.map(d => {
                router.addRoute(d);
            })
            resolve(menuList);
            }
            else {
            this.menus = [];
            ElMessage({
                message: msg,
                type: "error",
            });
            }
        });
        },
    },
    persist: {
        enabled: true,
        strategies: [
        {
            // 可以是localStorage或sessionStorage
            storage: localStorage,
            // 指定需要持久化的属性
            paths: ['token', 'expiresDate', 'userInfo', 'menus']
        }
        ]
    },
    })


    const defineRouteComponents: Record<string, any> = {
    frameWork: () => import('@/views/framework/index.vue')
    };
    const defineRouteComponentKeys = Object.keys(defineRouteComponents);
    export const setMenuData = (
    routeMap: any[],
    ) => {
    return routeMap
        .map(item => {
        const pathArray = item.component.split('/');
        const url = ref<any>();
        if (pathArray.length > 0) {
            if (pathArray.length === 3)
            url.value = import(`../${pathArray[1]}/${pathArray[2]}.vue`);
            if (pathArray.length === 4)
            url.value = import(`../${pathArray[1]}/${pathArray[2]}/${pathArray[3]}.vue`);
            if (pathArray.length === 5)
            url.value = import(`../${pathArray[1]}/${pathArray[2]}/${pathArray[3]}/${pathArray[4]}.vue`);
        };
        const { name, requireAuth, id } = item || {};
        const currentRouter: RouteRecordRaw = {
            // 如果路由设置了 path，则作为默认 path，否则 路由地址 动态拼接生成如 /dashboard/workplace
            path: item.path,
            // 路由名称，建议唯一
            //name: `${item.id}`,
            // meta: 页面标题, 菜单图标, 页面权限(供指令权限用，可去掉)
            meta: {
            name,
            requireAuth,
            id
            },
            name: item.name,
            children: [],
            // 该路由对应页面的 组件 (动态加载 @/views/ 下面的路径文件)
            component: item.component && defineRouteComponentKeys.includes(item.component)
            ? defineRouteComponents[item.component]
            : () => url.value,

        };

        // 为了防止出现后端返回结果不规范，处理有可能出现拼接出两个 反斜杠
        if (!currentRouter.path.startsWith('http')) {
            currentRouter.path = currentRouter.path.replace('//', '/');
        }

        // 重定向
        item.redirect && (currentRouter.redirect = item.redirect);
        if (item.children != null) {
            // 子菜单，递归处理
            currentRouter.children = setMenuData(item.children);
        }
        if (currentRouter.children === undefined || currentRouter.children.length <= 0) {
            currentRouter.children;
        }
        return currentRouter;
        })
        .filter(item => item);
    };
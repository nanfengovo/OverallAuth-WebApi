import { createRouter, createWebHashHistory, NavigationGuardNext, RouteLocationNormalized } from 'vue-router'
import { routes } from './module/base-routes'
import NProgress from 'nprogress'
import 'nprogress/nprogress.css'

NProgress.configure({ showSpinner: false })

const router = createRouter({
  history: createWebHashHistory(), //开发环境
routes
})

/**
路由守卫，访问路由菜单前拦截
 * @param to 目标
 * @param from 来至 
 */
    router.beforeEach((to: RouteLocationNormalized, from: RouteLocationNormalized, next: NavigationGuardNext) => {
    NProgress.start();
    debugger;
    if (to.meta.requireAuth) {
        next();
    } else if (to.matched.length == 0) {
        next({ path: '/panel' })
    } else {
        next();
    }
    })

    router.afterEach(() => {
    NProgress.done();
    })

export default router
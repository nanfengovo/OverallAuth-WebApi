import { createRouter, createWebHashHistory, NavigationGuardNext, RouteLocationNormalized } from 'vue-router'
import { routes } from './module/base-routes'
import NProgress from 'nprogress'
import 'nprogress/nprogress.css'
import { useUserStore } from '@/store/user'

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
//     router.beforeEach((to: RouteLocationNormalized, from: RouteLocationNormalized, next: NavigationGuardNext) => {
//         NProgress.start();
//         const userStore = useUserStore();
//         const endTime = new Date(userStore.expiresDate);
//         const currentTime = new Date();
//         // 判断是否需要认证以及过期时间
// if (to.meta.requireAuth) {
//     if (endTime < currentTime) {
//       // 如果已过期，跳转到登录页
//         router.push('/login');
//         return;  // 提前退出，不继续执行后面的逻辑
//     } else {
//         next();  // 认证通过，继续路由导航
//         return;
//     }
// }

//   // 如果没有匹配的路由，则跳转到登录页
//     if (to.matched.length === 0) {
//     next({ path: '/login' });
//     } else {
//     next();  // 否则继续导航
//     }
// }
// )

router.beforeEach((to: RouteLocationNormalized, from: RouteLocationNormalized, next: NavigationGuardNext) => {
  NProgress.start();
  const userStore = useUserStore();
  const endTime = new Date(userStore.expiresDate);
  const currentTime = new Date();
  // to.path = to.path;
  const time= isNaN(endTime.getTime())? null : endTime;
  if ((to.meta.requireAuth && time ==null)||(to.meta.requireAuth && endTime < currentTime)) {
    router.push('/login')
  }
  // if (to.meta.requireAuth && endTime < currentTime) {
  //   router.push('/login')
  // }
  else if (to.meta.requireAuth) {
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
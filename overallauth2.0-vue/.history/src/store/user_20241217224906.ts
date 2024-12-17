    import router from '@/router'
import { defineStore } from 'pinia'
import {routes} from '../router/module/base-routes'
    export const useUserStore = defineStore(
    'user', {
    state: () => ({
        token: '',
        expiresDate: '',
        userInfo: {},
        // menus:[] as any,
        menus:routes
    }),

    actions: {},
    //persist:true
    persist: {
        enabled: true,
        strategies: [
        {
            // 可以是localStorage或sessionStorage
            storage: localStorage,
            // 指定需要持久化的属性
            paths: ['token','expiresDate','userInfo','menus']
        }
        ]
    },
    })
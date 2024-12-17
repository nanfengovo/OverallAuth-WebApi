    import { defineStore } from 'pinia'
    export const useUserStore = defineStore(
    'user', {
    state: () => ({
        token: '',
        expiresDate: '',
        userInfo: {},
        menus:[] as any,
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
            paths: ['token','expiresDate','userInfo']
        }
        ]
    },
    })
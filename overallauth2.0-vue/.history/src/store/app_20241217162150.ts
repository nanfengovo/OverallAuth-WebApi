    import { defineStore } from 'pinia'

    export const useAppStore = defineStore({
    id: 'app',
    state: () => {
        return {
        tab: true,
        logo: true,
        level: true,
        inverted: false,
        routerAlive: true,
        collapse: false,
        subfield: false,
        locale: "zh_CN",
        subfieldPosition: "side",
        theme: 'light',
        breadcrumb: true,
        sideWidth: "220px",
        sideTheme: 'dark',
        greyMode: false,
        accordion: true,
        tagsTheme: 'concise',
        keepAliveList: [],
        themeVariable: {
            "--global-checked-color": "#5fb878",
            "--global-primary-color": "#009688",
            "--global-normal-color": "#1e9fff",
            "--global-danger-color": "#ff5722",
            "--global-warm-color": "#ffb800",
        },
        }
    },
    persist: {
        enabled: true,
        strategies: [
        {
            // 可以是localStorage或sessionStorage
            storage: localStorage,
            // 指定需要持久化的属性
            paths: ['token', 'expiresDate', 'userInfo']
        }
        ]
    },
    })
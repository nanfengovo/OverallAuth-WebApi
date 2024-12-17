import { createApp } from 'vue'
import App from './App.vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import * as Icons from '@element-plus/icons-vue'
import router from 'src/router/module/base-routes'

const app = createApp(App)
app.use(ElementPlus)
for (const [key, component] of Object.entries(Icons)) {
    app.component(key, component)
    }
    app.use(router)
app.mount('#app')
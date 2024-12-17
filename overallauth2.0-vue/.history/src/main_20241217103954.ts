import { createApp } from 'vue'
import App from './App.vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import * as Icons from '@element-plus/icons-vue'
import { createPinia } from '../node_modules/pinia/dist/pinia'
import router from './router'

const app = createApp(App)
app.use(ElementPlus)
const pinia = createPinia();
app.use(pinia)
app.use(router)
for (const [key, component] of Object.entries(Icons)) {
    app.component(key, component)
    }
    app.use(router)
app.mount('#app')
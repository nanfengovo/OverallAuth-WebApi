import router from '@/router';
import { useUserStore } from '@/store/user';
import axios, { AxiosRequestHeaders, AxiosResponse, InternalAxiosRequestConfig } from 'axios';
import { ElMessage } from 'element-plus';

//声明模型参数
type TAxiosOption = {
    timeout: number;
    baseURL: string;
}

//配置赋值
const config: TAxiosOption = {
    timeout: 5000,
    baseURL: "http://localhost:5184/",    // 本地api接口地址
}

class Http {
    service;
    constructor(config: TAxiosOption) {
        this.service = axios.create(config)

   /* 请求拦截 */
   this.service.interceptors.request.use((config: InternalAxiosRequestConfig) => {
    //可以在这里做请求拦截处理   如：请求接口前，需要传入的token
    const userInfoStore = useUserStore();
    if (userInfoStore.token) {
        (config.headers as AxiosRequestHeaders).token = userInfoStore.token as string
        config.headers["Authorization"] = "Bearer " + userInfoStore.token;
    } else {
        if (router.currentRoute.value.path !== '/login') {
            router.push('/login');
        }
    }
    return config
}, (error: any) => {
    ElMessage({
        message: "接口调用失败",
        type: "error",
    });
    return error.message;
    //return Promise.reject(error);
})

        /* 响应拦截 */
        this.service.interceptors.response.use((response: AxiosResponse<any>) => {
            // eslint-disable-next-line no-debugger
            // debugger;
            switch (response.data.code) {
                case 200:
                    return response.data;
                case 500:
                    ElMessage({
                        message:response.data.msg,
                        type: 'error',
                    })
                    //这里面可以写错误提示，反馈给前端
                    return response.data;
                case 99991:
                    ElMessage({
                        message:response.data.msg,
                        type: 'warning',
                    })
                    return response.data;
                case 99992:
                    ElMessage({
                        message:response.data.msg,
                        type: 'error',
                    })
                    return response.data;
                case 99998:
                    return response.data;
                default:
                    break;
            }
        }, (error: any) => {
            return Promise.reject(error)
        })
    }

    /* GET 方法 */
    get<T>(url: string, params?: object, _object = {}): Promise<any> {
        return this.service.get(url, { params, ..._object })
    }
    /* POST 方法 */
    post<T>(url: string, params?: object, _object = {}): Promise<any> {
        return this.service.post(url, params, _object)
    }
    /* PUT 方法 */
    put<T>(url: string, params?: object, _object = {}): Promise<any> {
        return this.service.put(url, params, _object)
    }
    /* DELETE 方法 */
    delete<T>(url: string, params?: any, _object = {}): Promise<any> {
        return this.service.delete(url, { params, ..._object })
    }
}

export default new Http(config)
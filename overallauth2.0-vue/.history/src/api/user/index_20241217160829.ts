import { LoginInput } from '@/model/user/LoginInput';
import Http from '../http';

export const login = function(loginForm: LoginInput) {
    return Http.post('/api/SysUser/Login', loginForm)
}
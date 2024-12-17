import Http from '../http';

export const TestAutofac = function () {
    return Http.get('/api/SysUser/TestAutofac');
}
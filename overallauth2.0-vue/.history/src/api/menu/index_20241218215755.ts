import Http from '../http';
export const getMenuTreeData = async function() {
    return await Http.get('/api/SysMenu/GetMenuTreeList');
}
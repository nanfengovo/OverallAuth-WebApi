using DomainService.IService;
using Infrastructure;
using Infrastructure.IRepository;
using Model;
using Model.BusinessModel.OutPut;
using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DomainService.Service
{
    internal class SysUserService : ISysUserService
    {
        #region 构造实例化
        public readonly ISysUserRepository _sysUserRepository;
        public SysUserService(ISysUserRepository sysUserRepository)
        {
            _sysUserRepository = sysUserRepository;
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public List<SysUser> GetAllUser()
        {
            return _sysUserRepository.GetAll(BaseSqlRepository.sysUser_selectAllSql);
        }

 
        #endregion

        /// <summary>
        /// 测试TestAutofac
        /// </summary>
        /// <returns></returns>
        public string TestAutofac()
        {
            return _sysUserRepository.TestAutofac();
        }

        /// <summary>
        /// 根据用户名和密码获取用户信息
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ReceiveStatus<LoginOutPut> GetUserMsg(string username, string password)
        {
            ReceiveStatus<LoginOutPut> receiveStatus = new ReceiveStatus<LoginOutPut>();
            List<LoginOutPut> loginoutputlist = new List<LoginOutPut>();
            if(string.IsNullOrEmpty(username))
            {
                return ExceptionHelper<LoginOutPut>.CustomExceptionData("用户名不能为空！");
            }
            if(string.IsNullOrEmpty(password))
            {
                return ExceptionHelper<LoginOutPut>.CustomExceptionData("密码不能为空！");
            }
            var result = _sysUserRepository.GetUserMsg(username,password);
            if(result ==null)
            {
                return ExceptionHelper<LoginOutPut>.CustomExceptionData($"用户{username}不存在或用户名密码错误！");
            }
            if(result.IsOpen==false)
            {
                return ExceptionHelper<LoginOutPut>.CustomExceptionData($"用户{username}已停用！");
            }
            LoginOutPut loginresult = new LoginOutPut()
            {
                UserId = result.UserId,
                UserName = result.UserName,
                Token = string.Empty,
                ExpiresDate = string.Empty
            };
            loginoutputlist.Add(loginresult);
            receiveStatus.data = loginoutputlist;
            receiveStatus.msg = "登录成功！";
            return receiveStatus;
        }
    }
}

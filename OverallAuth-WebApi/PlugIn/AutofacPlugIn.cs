using Autofac;
using Autofac.Extras.DynamicProxy;
using System.Reflection;

namespace OverallAuth_WebApi.PlugIn
{
    /// <summary>
    /// Autofac插件
    /// </summary>
    public class AutofacPlugIn : Autofac.Module
    {
        /// <summary>
        /// 重写Autofac的Load方法
        /// </summary>
        /// <param name="containerBuilder"></param>
        protected override void Load(ContainerBuilder containerBuilder)
        {
            //服务项目程序集
            Assembly service = Assembly.Load("DomainService");
            Assembly intracface = Assembly.Load("Infrastructure");

            //注册aop
            containerBuilder.RegisterType(typeof(AopPlugIn));

            //项目必须以xxx结尾
            containerBuilder.RegisterAssemblyTypes(service).Where(n => n.Name.EndsWith("Service") && !n.IsAbstract)
                .InstancePerLifetimeScope().AsImplementedInterfaces().InterceptedBy(typeof(AopPlugIn)).EnableInterfaceInterceptors();
            containerBuilder.RegisterAssemblyTypes(intracface).Where(n => n.Name.EndsWith("Repository") && !n.IsAbstract)
               .InstancePerLifetimeScope().AsImplementedInterfaces();
        }
    }
}

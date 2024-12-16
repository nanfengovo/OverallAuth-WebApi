using Castle.DynamicProxy;

namespace OverallAuth_WebApi.PlugIn
{
    /// <summary>
    /// aop插件
    /// </summary>
    public class AopPlugIn : IInterceptor
    {
        /// <summary>
        /// 拦截
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            //当前调用方法名称
            var methodName = invocation.Method.Name;

            //当前调用方法所在服务名称
            var interfaceServiceName = "I" + invocation.TargetType.Name;

            //获取当前调用的方法信息
            var methodInfo = invocation.Method;

            //当前方法参数数量
            var methodParameterCount = methodInfo.GetParameters().Length;

            // 当前接口所有参数
            foreach (var parameter in methodInfo.GetParameters())
            {
                //参数名称
                var ParameterName = parameter.Name;
                //参数值
                var ParameterValue = invocation.Arguments[parameter.Position];
                //参数类型
                var ParameterType = invocation.Arguments[parameter.Position] == null ? string.Empty : invocation.Arguments[parameter.Position].GetType().Name;
            }

            /*
             你可以在方法执行前，编写任何逻辑
             */

            //执行调用方法
            invocation.Proceed();

            /*
             你可以在方法执行后，编写任何逻辑
             */

            //当前接口返回值
            var value = invocation.ReturnValue;
        }
    }
}

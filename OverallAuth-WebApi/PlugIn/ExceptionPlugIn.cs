using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Model;
using Utility.Enum;
using Newtonsoft.Json;

namespace OverallAuth_WebApi.PlugIn
{
    /// <summary>
    /// 全局异常捕获中间件
    /// </summary>
    public class ExceptionPlugIn : IAsyncExceptionFilter
    {
        /// <summary>
        /// 全局异常捕获接口
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task OnExceptionAsync(ExceptionContext context)
        {
            //异常信息
            Exception ex = context.Exception;

            //异常位置
            var DisplayName = context.ActionDescriptor.DisplayName;

            //异常行号
            int lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                lineNumber = Convert.ToInt32(lineNumberText.Substring(0, lineNumberText.IndexOf("\r\n")));
            }

            // 如果异常没有被处理则进行处理
            if (context.ExceptionHandled == false)
            {
                string exceptionMsg = "错误位置：" + DisplayName + "\r\n" + "错误行号：" + lineNumber + "\r\n" + "错误信息：" + ex.Message;
                // 定义返回类型
                var result = new ReceiveStatus<string>
                {
                    code = CodeStatuEnum.Error,
                    msg = "错误信息：" + exceptionMsg,
                    success = false,
                };
                context.Result = new ContentResult
                {
                    // 返回状态码设置为200，表示
                    StatusCode = StatusCodes.Status500InternalServerError,
                    // 设置返回格式
                    ContentType = "application/json;charset=utf-8",
                    Content = JsonConvert.SerializeObject(result)
                };
                //记录日志

            }
            // 设置为true，表示异常已经被处理了
            context.ExceptionHandled = true;
            return Task.CompletedTask;
        }
    }
}

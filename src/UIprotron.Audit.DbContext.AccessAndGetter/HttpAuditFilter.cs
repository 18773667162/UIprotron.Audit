using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Diagnostics;
using UIprotron.Audit.Core;

namespace UIprotron.Audit.DbContext.AccessAndGetter
{
    public class HttpAuditFilter : IAsyncActionFilter
    {
        private readonly IAuditLogManager<AuditLogActionInfo, ActionExecutingContext> _auditLogManager;


        public HttpAuditFilter(
            IAuditLogManager<AuditLogActionInfo, ActionExecutingContext> auditLogManager
        ) 
        {
            _auditLogManager = auditLogManager??throw new ArgumentException(nameof(_auditLogManager));
        }


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!_auditLogManager.ShouldSaveAudit(context))
            {
                await next();
                return;
            }
            Type? type = ((ControllerActionDescriptor)context.ActionDescriptor).ControllerTypeInfo.AsType();
            //方法信息
            System.Reflection.MethodInfo? method = ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo;
            //方法参数
            var arguments = context.ActionArguments;
            //开始计时
            var stopwatch = Stopwatch.StartNew();

            var auditInfo = new AuditLogActionInfo();
            ActionExecutedContext result = null;
            try
            {
                result = await next();
                if (result.Exception != null && !result.ExceptionHandled)
                {
                    auditInfo.Exceptions.Add(result.Exception);
                }
            }
            catch (Exception ex)
            {
                auditInfo.Exceptions.Add(ex);
                throw;
            }
            finally
            {
                stopwatch.Stop();
                auditInfo.ExecutionDuration = Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds);

                if (result != null)
                {
                    switch (result.Result)
                    {
                        case ObjectResult objectResult:
                            auditInfo.Parameters = JsonConvert.SerializeObject(objectResult.Value);
                            break;

                        case Microsoft.AspNetCore.Mvc.ContentResult contentResult:
                            auditInfo.Parameters = contentResult.Content;
                            break;
                    }
                }
                Console.WriteLine(auditInfo.ToString());
                //保存审计日志
                await _auditLogManager.CurrentStore.SaveChange(auditInfo);
            }
        }
    }
}

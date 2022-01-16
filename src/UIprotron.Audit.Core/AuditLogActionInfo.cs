using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public class AuditLogActionInfo : AuditLogInfo
    {
        /// <summary>
        /// 请求的URL
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// HTTP响应状态码
        /// </summary>
        public int HttpStatusCode { get; }

        /// <summary>
        /// 当前客户端的名称,如果有的话
        /// </summary>
        public string ClientName { get; }

        /// <summary>
        /// 客户端/用户设备的IP地址.
        /// </summary>
        public string ClientIpAddress { get; }

        /// <summary>
        /// 当前用户的浏览器名称/版本信息,如果有的话
        /// </summary>
        public string BrowserInfo { get; }

        /// <summary>
        /// 当前HTTP请求的方法(GET,POST,PUT,DELETE ...等)
        /// </summary>
        public string HttpMethod { get; }

        /// <summary>
        /// 执行的控制器/服务的名称.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 控制器/服务执行的方法的名称.
        /// </summary>
        public string MethodName { get; }

        /// <summary>
        /// 传递给方法的参数的JSON格文本.
        /// </summary>
        public string Parameters { get; }

        /// <summary>
        /// 执行的时间
        /// </summary>
        public long ExecutionTime { get; }

        /// <summary>
        /// 方法执行时长,以毫秒为单位. 可以用来观察方法的性能
        /// </summary>
        public long ExecutionDuration { get; }

    }
}

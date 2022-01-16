using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public class EntityPropertyChangeInfo
    {
        /// <summary>
        /// 属性的新值. 如果实体已被删除为 null
        /// </summary>
        public string NewValue { get; set; }

        /// <summary>
        /// 变更前旧/初始值. 如果实体是新创建为 null
        /// </summary>
        public string OriginalValue { get; set; }

        /// <summary>
        /// 实体类的属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性类型的完整命名空间名称
        /// </summary>
        public string PropertyTypeFullName { get; set; }
    }
}

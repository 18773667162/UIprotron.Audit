using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public class AuditLogEntityInfo : AuditLogInfo
    {
        public AuditLogEntityInfo() 
        {
            ChangeTime = DateTime.Now;
        }

        public DateTime ChangeTime { get; }

        public ChangeTypeEnum ChangeType { get; set; }

        public string EntityId { get; set; }

        public string EntityTypeFullName { get; set; }
    }
}

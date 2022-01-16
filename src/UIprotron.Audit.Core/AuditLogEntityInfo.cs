using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public class AuditLogEntityInfo:AuditLogInfo
    {

        public AuditLogEntityInfo() 
        {

        }

        public DateTime ChangeTime { get; }

        public ChangeTypeEnum ChangeType { get; }

        public string EntityId { get; }

        public string EntityTypeFullName { get; }

        public List<EntityPropertyChangeInfo> EntityPropertyChangeInfos { get; }
    }
}

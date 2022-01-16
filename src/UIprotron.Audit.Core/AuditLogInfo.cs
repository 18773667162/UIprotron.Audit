using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public abstract class AuditLogInfo
    {
        public AuditLogInfo()
        {
            Id = Guid.NewGuid().ToString();
            Exceptions = new List<Exception>();
            ExtraProperties = new ExtraPropertyDictionary();
            Comments = new List<string>();
        }

        public string Id { get; }

        public long? ExecutionTime { get; set; }

        public string ApplicationName { get; set; }

        public List<Exception> Exceptions { get; }

        public ExtraPropertyDictionary ExtraProperties { get; }

        public List<string> Comments { get; }
    }
}

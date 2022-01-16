using System.Data.Common;
using UIprotron.Audit.Core;

namespace UIprotron.Audit.HttpContext.AccessAndGetter
{
    /// <summary>
    /// 假的,目前还没想好实现方案
    /// </summary>
    public class DbAuditLogManager : IAuditLogManager<DbConnection>
    {
        public bool ShouldSaveAudit(DbConnection message)
        {
            throw new NotImplementedException();
        }
    }
}

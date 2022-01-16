using System.Linq.Expressions;
using UIprotron.Audit.Core;
using UIprotron.Audit.Core.Store;

namespace UIprotron.Audit.Store.EntityFramework.Mysql
{
    public class HttpContextAuditLogStore : IAuditLogStore<AuditLogActionInfo>
    {
        public Task<AuditLogActionInfo> GetAuditLogInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuditLogActionInfo>> GetAuditLogInfos(Expression<Func<bool, AuditLogActionInfo>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChange(AuditLogActionInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges(IEnumerable<AuditLogActionInfo> entities)
        {
            throw new NotImplementedException();
        }
    }
}

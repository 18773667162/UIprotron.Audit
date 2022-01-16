using System.Linq.Expressions;
using UIprotron.Audit.Core;
using UIprotron.Audit.Core.Store;

namespace UIprotron.Audit.Store.EntityFramework.Mysql
{
    public class DbContextAuditLogStore : IAuditLogStore<AuditLogEntityInfo>
    {
        public Task<AuditLogEntityInfo> GetAuditLogInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuditLogEntityInfo>> GetAuditLogInfos(Expression<Func<bool, AuditLogEntityInfo>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChange(AuditLogEntityInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges(IEnumerable<AuditLogEntityInfo> entities)
        {
            throw new NotImplementedException();
        }
    }
}

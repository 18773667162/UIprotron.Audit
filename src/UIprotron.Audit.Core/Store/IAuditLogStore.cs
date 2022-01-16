using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core.Store
{
    public interface IAuditLogStore<T> where T : AuditLogInfo
    {
        Task<int> SaveChange(T entity);

        Task<int> SaveChanges(IEnumerable<T> entities);

        Task<T> GetAuditLogInfo(int id);

        Task<IEnumerable<T>> GetAuditLogInfos(Expression<Func<bool, T>> expression);
    }
}

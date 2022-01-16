using UIprotron.Audit.Core.Store;

namespace UIprotron.Audit.Core
{
    public interface IAuditLogManager<T, TContext>
    {
        bool ShouldSaveAudit(TContext message);

        IAuditLogStore<AuditLogInfo> CurrentStore { get; }
    }
}

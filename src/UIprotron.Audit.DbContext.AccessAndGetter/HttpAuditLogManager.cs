using Microsoft.AspNetCore.Mvc.Filters;
using UIprotron.Audit.Core;

namespace UIprotron.Audit.DbContext.AccessAndGetter
{
    public class HttpAuditLogManager : IAuditLogManager<AuditLogActionInfo, ActionExecutingContext>
    {
        public bool ShouldSaveAudit(ActionExecutingContext message)
        {
            throw new NotImplementedException();
        }
    }
}

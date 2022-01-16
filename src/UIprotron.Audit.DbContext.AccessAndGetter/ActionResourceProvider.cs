using UIprotron.Audit.Core.Providers;
using UIprotron.Audit.Core.Resources;

namespace UIprotron.Audit.DbContext.AccessAndGetter
{
    public class ActionResourceProvider : IResourceProvider<ActionResources>
    {
        public IEnumerable<ActionResources> GetResources()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ActionResources>> GetResourcesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

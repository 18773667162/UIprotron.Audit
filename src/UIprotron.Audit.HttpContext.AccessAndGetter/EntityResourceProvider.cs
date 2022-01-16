using UIprotron.Audit.Core.Providers;
using UIprotron.Audit.Core.Resources;

namespace UIprotron.Audit.HttpContext.AccessAndGetter
{
    public class EntityResourceProvider : IResourceProvider<EntityResources>
    {
        public IEnumerable<EntityResources> GetResources()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntityResources>> GetResourcesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

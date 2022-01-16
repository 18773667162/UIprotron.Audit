using UIprotron.Audit.Core.Resources;
using UIprotron.Audit.Core.Store;

namespace UIprotron.Audit.Store.EntityFramework.Mysql
{
    public abstract class ResourceStore<T> : IResourceStore<T>
        where T : Resources
    {
        public virtual Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task CreateEntitiesAsync(IEnumerable<T> enties)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(string key)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetEntityById(string key)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

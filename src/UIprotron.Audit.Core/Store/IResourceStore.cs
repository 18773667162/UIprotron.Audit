using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core.Store
{
    public interface IResourceStore<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetEntityById(string key);

        Task CreateAsync(T entity);

        Task CreateEntitiesAsync(IEnumerable<T> enties);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(string key);
    }
}

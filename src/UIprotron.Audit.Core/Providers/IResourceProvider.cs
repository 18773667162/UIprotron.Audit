namespace UIprotron.Audit.Core.Providers
{
    public interface IResourceProvider<T> where T : class
    {
        IEnumerable<T> GetResources();

        Task<IEnumerable<T>> GetResourcesAsync();
    }
}

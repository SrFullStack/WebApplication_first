using Entitiy;

namespace Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
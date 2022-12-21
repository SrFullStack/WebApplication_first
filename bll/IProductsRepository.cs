using Entitiy;

namespace T_Repository
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
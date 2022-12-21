using Entitiy;

namespace Service
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
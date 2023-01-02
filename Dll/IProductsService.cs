using Entitiy;

namespace Service
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProducts(string? name, int?[] categoryIds, int? minPrice, int? maxPrice);
    }
}
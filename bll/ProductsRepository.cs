using Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T_Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly UserContext _dbContext;
        public ProductsRepository(UserContext dbContext)
        {
            _dbContext = dbContext;


        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            List<Product> product = await _dbContext.Products.ToListAsync();
            return product;
        }

    }
}

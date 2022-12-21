using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiy;
using T_Repository;

namespace Service
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _IProductsRepository;
        public ProductsService(IProductsRepository IProductsRepository)
        {
            _IProductsRepository = IProductsRepository;
        }


        async public Task<IEnumerable<Product>> GetProducts()
        {
            {
                return await _IProductsRepository.GetProducts();


            }

        }


    }
}

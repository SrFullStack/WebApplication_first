using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Repository;
using Entitiy;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _ICategoryRepository;
        public CategoryService(ICategoryRepository ICategoryRepository)
        {
            _ICategoryRepository = ICategoryRepository;
        }


        async public Task<IEnumerable<Category>> GetCategories()
        {
            {
                return await _ICategoryRepository.GetCategories();


            }

        }

    }
}

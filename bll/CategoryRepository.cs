
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiy;
using Microsoft.EntityFrameworkCore;

namespace T_Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly UserContext _dbContext;
        public CategoryRepository(UserContext dbContext)
        {
            _dbContext = dbContext;


        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            List<Category> categories = await _dbContext.Categories.ToListAsync();
            return categories;
        }
    }
}

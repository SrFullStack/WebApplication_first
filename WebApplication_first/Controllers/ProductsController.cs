using Microsoft.AspNetCore.Mvc;
using Service;
using Entitiy;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsService _IProductsService;


        public ProductsController(IProductsService IProductsService)
        {
            _IProductsService = IProductsService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
      
       


            public async Task<IEnumerable<Product>> Get([FromQuery] string? name, [FromQuery] int?[] categoryIds, [FromQuery] int? minPrice, [FromQuery] int? maxPrice)
        {
            return await _IProductsService.GetProducts(name, categoryIds, minPrice, maxPrice);
        }


        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

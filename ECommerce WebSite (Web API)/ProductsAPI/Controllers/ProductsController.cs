using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using ProductsAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProdcutsController>
        private readonly ProductDbContext _context;
        private readonly IProductRepository productRepository;

        public ProductsController(ProductDbContext context,IProductRepository productRepository)
        {
            this._context=context;
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductsData(string? genderFilter, string? productCategoryFilter, string? productSubCategoryFilter, string? sortBy, bool? isAscending, int pageNumber = 1, int pageSize = 6)
        {
            var result = await this.productRepository.GetAllProducts(genderFilter,productCategoryFilter,productSubCategoryFilter,sortBy,isAscending ?? true,pageNumber,pageSize);
            return Ok(result);
        }

        // GET api/<ProdcutsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var result =await this.productRepository.GetProductByID(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/<ProdcutsController>
        [HttpPost]
        public async Task<IActionResult> Post(Product newProduct)
        {
            await this.productRepository.AddProduct(newProduct);
            

            return CreatedAtAction(nameof(GetByID), new { id = newProduct.Id }, newProduct);

        }

        // PUT api/<ProdcutsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,Product updatedProduct)
        {
            var result = await this.productRepository.UpdateProduct(id,updatedProduct);
            if (result == null)
            {
                return NotFound();
            }
          
            return NoContent();

        }

        // DELETE api/<ProdcutsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result =await this.productRepository.DeleteProduct(id);
            if (result == null)
            {
                return NotFound();
            }
          
            return NoContent() ;
        }
    }
}

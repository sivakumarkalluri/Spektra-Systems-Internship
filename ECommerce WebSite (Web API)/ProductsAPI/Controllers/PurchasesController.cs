using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using ProductsAPI.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        // GET: api/<PurchasesController>
        private readonly ProductDbContext _context;
        public PurchasesController(ProductDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var purchaseData = await this._context.Purchases.ToListAsync();

            var result = new List<PurchaseDTO>();
            foreach(var  purchase in purchaseData)
            {
                result.Add(new PurchaseDTO()
                {
                    id=purchase.Id,
                    name=purchase.Name,
                    price=purchase.Price,
                    quantity=purchase.Quantity,
                    image=purchase.Image
                }
                    );
            }
           
            return Ok(result);
        }

        // GET api/<PurchasesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PurchasesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PurchasesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PurchasesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Catalog;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // GET: api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ProductService.GetAll());
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = ProductService.GetById(id);

            if (product == null)
                return NotFound("Product Not Found");

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public IActionResult Insert(Product product)
        {
            ProductService.Insert(product);
            return Ok("Product Added Successfully");
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var result = ProductService.Update(id, product);
            return Ok(result);
        }

        // DELETE: api/products/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = ProductService.Delete(id);
            return Ok(result);
        }
    }
}
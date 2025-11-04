using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogs.Server.Services;

namespace ProductCatalogs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service = new();

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                var products = _service.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                var product = _service.GetProduct(id);
                if (product == null)
                    return NotFound("Product not found.");
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("GetProductAttributes/{id}")]
        public IActionResult GetProductAttributes(int id)
        {
            try
            {
                var attrs = _service.GetProductAttributes(id);
                if (!attrs.Any())
                    return NotFound("No attributes found.");
                return Ok(attrs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpGet("pbi")]
        public IActionResult GetProductsByPbi()
        {
            try
            {
                var products = _service.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}

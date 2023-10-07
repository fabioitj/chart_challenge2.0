using Back.Application.DTOs.Product;
using Back.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<ProductResponse>>> GetAll([FromQuery] ProductRequest productRequest)
        {
            var response = await _productService.Get(productRequest);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}

using Back.Application.DTOs.Brand;
using Back.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BrandController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<BrandResponse>>> GetAll([FromQuery] BrandRequest brandRequest)
        {
            var response = await _brandService.Get(brandRequest);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}

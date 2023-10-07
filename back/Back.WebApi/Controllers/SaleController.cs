using Back.Application.DTOs.Sale;
using Back.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class SaleController : ControllerBase
    {
        private ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<SaleResponse>>> GetAll([FromQuery] SaleRequest saleRequest)
        {
            var response = await _saleService.Get(saleRequest);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}

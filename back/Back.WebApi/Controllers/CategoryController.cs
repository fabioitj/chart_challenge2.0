using Back.Application.DTOs.Category;
using Back.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<CategoryResponse>>> GetAll()
        {
            var response = await _categoryService.Get();

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}

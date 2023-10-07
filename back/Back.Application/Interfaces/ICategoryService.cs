using Back.Application.DTOs.Category;

namespace Back.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IList<CategoryResponse>> Get();
    }
}

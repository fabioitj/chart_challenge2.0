using Back.Application.DTOs.Category;
using Back.Application.Interfaces;
using Back.Application.Mappers;
using Back.Domain.Interfaces;

namespace Back.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepositoryAsync _categoryRepositoryAsync;

        public CategoryService(ICategoryRepositoryAsync categoryRepositoryAsync)
        {
            _categoryRepositoryAsync = categoryRepositoryAsync;
        }

        public async Task<IList<CategoryResponse>> Get()
        {
            var lstAllBloodPressure = await _categoryRepositoryAsync.Get();

            if (lstAllBloodPressure == null || lstAllBloodPressure.Count == 0)
            {
                return null;
            }

            var response = CategoryMapper.ListCategoryToListCategoryResponse(lstAllBloodPressure);
            return response;
        }
    }
}

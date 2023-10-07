using Back.Application.DTOs.Category;
using Back.Domain.Entities;

namespace Back.Application.Mappers
{
    public static class CategoryMapper
    {
        public static IList<CategoryResponse>? ListCategoryToListCategoryResponse(IList<Category> lstCategory)
        {
            if (lstCategory == null)
            {
                return null;
            }

            IList<CategoryResponse> lstCategoryDTOs = new List<CategoryResponse>();
            foreach (var item in lstCategory)
            {
                lstCategoryDTOs.Add(CategoryToCategoryResponse(item));
            }

            return lstCategoryDTOs;
        }

        public static CategoryResponse CategoryToCategoryResponse(Category category)
        {
            if (category == null)
            {
                return null;
            }

            return new CategoryResponse()
            {
                id = category.id,
                name = category.name
            };
        }
    }
}

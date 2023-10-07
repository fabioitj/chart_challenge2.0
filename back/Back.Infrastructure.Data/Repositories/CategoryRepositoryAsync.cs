using Back.Domain.Entities;
using Back.Domain.Interfaces;

namespace Back.Infrastructure.Data.Repositories
{
    public class CategoryRepositoryAsync : ICategoryRepositoryAsync
    {
        public async Task<IList<Category>> Get()
        {
            var mockCategories = new List<Category>
            {
                new Category { id = "1", name = "Clothes" },
                new Category { id = "2", name = "Sneakers" },
                new Category { id = "3", name = "Accessories" },
            };

            return await Task.FromResult(mockCategories);
        }
    }        
}

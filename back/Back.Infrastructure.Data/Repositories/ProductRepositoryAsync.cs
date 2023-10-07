using Back.Domain.Entities;
using Back.Domain.Interfaces;

namespace Back.Infrastructure.Data.Repositories
{
    public class ProductRepositoryAsync : IProductRepositoryAsync
    {
        public async Task<IList<Product>> Get(string id_category)
        {
            var mockProducts = new List<Product>
            {
                new Product { id = "1", name = "T-shirt", id_category = "1" },
                new Product { id = "2", name = "Sweather", id_category = "1" },
                new Product { id = "3", name = "Coat", id_category = "1" },
                new Product { id = "4", name = "Boot", id_category = "2" },
                new Product { id = "5", name = "Slipper", id_category = "2" },
                new Product { id = "6", name = "Sandal", id_category = "2" },
                new Product { id = "7", name = "Neckless", id_category = "3" },
                new Product { id = "8", name = "Ring", id_category = "3" },
                new Product { id = "9", name = "Cap", id_category = "3" },
            };

            mockProducts = mockProducts.Where(_ => _.id_category == id_category).ToList();

            return await Task.FromResult(mockProducts);
        }
    }        
}

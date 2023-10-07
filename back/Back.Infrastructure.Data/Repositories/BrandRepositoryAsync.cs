using Back.Domain.Entities;
using Back.Domain.Interfaces;

namespace Back.Infrastructure.Data.Repositories
{
    public class BrandRepositoryAsync : IBrandRepositoryAsync
    {
        public async Task<IList<Brand>> Get(string id_product)
        {
            var mockBrands = new List<Brand>
            {
                new Brand { id = "1", name = "Calvin Klein", id_product = "1" },
                new Brand { id = "2", name = "Adidas", id_product = "2" },
                new Brand { id = "3", name = "Gucci", id_product = "3" },
                new Brand { id = "4", name = "Nike", id_product = "4" },
                new Brand { id = "5", name = "Havaianas", id_product = "5" },
                new Brand { id = "6", name = "Vizzano", id_product = "6" },
                new Brand { id = "7", name = "Morana", id_product = "7" },
                new Brand { id = "8", name = "Vivara", id_product = "8" },
                new Brand { id = "9", name = "Gap", id_product = "9" },
            };

            mockBrands = mockBrands.Where(_ => _.id_product == id_product).ToList();

            return await Task.FromResult(mockBrands);
        }
    }        
}

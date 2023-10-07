using Back.Domain.Entities;
using Back.Domain.Interfaces;

namespace Back.Infrastructure.Data.Repositories
{
    public class SaleRepositoryAsync : ISaleRepositoryAsync
    {
        public async Task<IList<Sale>> Get(string id_brand)
        {
            var mockSales = new List<Sale>
            {
                new Sale { id = "1", value = 300, month = 1, id_brand = "1" },
                new Sale { id = "2", value = 200, month = 4, id_brand = "1" },
                new Sale { id = "3", value = 100, month = 6, id_brand = "1" },
                new Sale { id = "4", value = 500, month = 9, id_brand = "1" },
                new Sale { id = "5", value = 250, month = 1, id_brand = "2" },
                new Sale { id = "6", value = 350, month = 5, id_brand = "2" },
                new Sale { id = "7", value = 50, month = 6, id_brand = "2" },
                new Sale { id = "8", value = 400, month = 7, id_brand = "2" },
                new Sale { id = "9", value = 200, month = 1, id_brand = "3" },
                new Sale { id = "10", value = 100, month = 2, id_brand = "3" },
                new Sale { id = "11", value = 600, month = 3, id_brand = "3" },
                new Sale { id = "12", value = 650, month = 9, id_brand = "3" },
                new Sale { id = "13", value = 150, month = 1, id_brand = "4" },
                new Sale { id = "14", value = 300, month = 3, id_brand = "4" },
                new Sale { id = "15", value = 150, month = 6, id_brand = "4" },
                new Sale { id = "16", value = 400, month = 9, id_brand = "4" },
                new Sale { id = "17", value = 200, month = 2, id_brand = "5" },
                new Sale { id = "18", value = 400, month = 4, id_brand = "5" },
                new Sale { id = "19", value = 600, month = 8, id_brand = "5" },
                new Sale { id = "20", value = 900, month = 9, id_brand = "5" },
                new Sale { id = "21", value = 150, month = 1, id_brand = "6" },
                new Sale { id = "22", value = 350, month = 3, id_brand = "6" },
                new Sale { id = "23", value = 100, month = 4, id_brand = "6" },
                new Sale { id = "24", value = 1000, month = 5, id_brand = "6" },
                new Sale { id = "25", value = 150, month = 1, id_brand = "7" },
                new Sale { id = "26", value = 250, month = 2, id_brand = "7" },
                new Sale { id = "27", value = 450, month = 3, id_brand = "7" },
                new Sale { id = "28", value = 500, month = 4, id_brand = "7" },
                new Sale { id = "29", value = 100, month = 1, id_brand = "8" },
                new Sale { id = "30", value = 250, month = 3, id_brand = "8" },
                new Sale { id = "31", value = 600, month = 6, id_brand = "8" },
                new Sale { id = "32", value = 500, month = 9, id_brand = "8" },
                new Sale { id = "33", value = 700, month = 1, id_brand = "9" },
                new Sale { id = "34", value = 250, month = 3, id_brand = "9" },
                new Sale { id = "35", value = 150, month = 6, id_brand = "9" },
                new Sale { id = "36", value = 700, month = 9, id_brand = "9" },
            };

            mockSales = mockSales.Where(_ => _.id_brand == id_brand).ToList();

            return await Task.FromResult(mockSales);
        }
    }        
}

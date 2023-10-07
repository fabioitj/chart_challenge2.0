using Back.Domain.Entities;

namespace Back.Domain.Interfaces
{
    public interface IProductRepositoryAsync
    {
        Task<IList<Product>> Get(string id_category);
    }
}

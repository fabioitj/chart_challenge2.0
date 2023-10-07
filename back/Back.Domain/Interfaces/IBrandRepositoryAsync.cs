using Back.Domain.Entities;

namespace Back.Domain.Interfaces
{
    public interface IBrandRepositoryAsync
    {
        Task<IList<Brand>> Get(string id_product);
    }
}

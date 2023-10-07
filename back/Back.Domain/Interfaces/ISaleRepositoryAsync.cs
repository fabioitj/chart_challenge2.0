using Back.Domain.Entities;

namespace Back.Domain.Interfaces
{
    public interface ISaleRepositoryAsync
    {
        Task<IList<Sale>> Get(string id_brand);
    }
}

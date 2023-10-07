using Back.Domain.Entities;

namespace Back.Domain.Interfaces
{
    public interface ICategoryRepositoryAsync
    {
        Task<IList<Category>> Get();
    }
}

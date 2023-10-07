using Back.Application.DTOs.Brand;

namespace Back.Application.Interfaces
{
    public interface IBrandService
    {
        Task<IList<BrandResponse>> Get(BrandRequest brandRequest);
    }
}

using Back.Application.DTOs.Product;

namespace Back.Application.Interfaces
{
    public interface IProductService
    {
        Task<IList<ProductResponse>> Get(ProductRequest productRequest);
    }
}

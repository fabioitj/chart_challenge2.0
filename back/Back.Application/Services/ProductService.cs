using Back.Application.DTOs.Product;
using Back.Application.Interfaces;
using Back.Application.Mappers;
using Back.Domain.Interfaces;

namespace Back.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepositoryAsync _productRepositoryAsync;

        public ProductService(IProductRepositoryAsync productRepositoryAsync)
        {
            _productRepositoryAsync = productRepositoryAsync;
        }

        public async Task<IList<ProductResponse>> Get(ProductRequest productRequest)
        {
            var lstAllBloodPressure = await _productRepositoryAsync.Get(productRequest.id_category);

            if (lstAllBloodPressure == null || lstAllBloodPressure.Count == 0)
            {
                return null;
            }

            var response = ProductMapper.ListProductToListProductResponse(lstAllBloodPressure);
            return response;
        }
    }
}

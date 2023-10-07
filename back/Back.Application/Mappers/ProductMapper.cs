using Back.Application.DTOs.Product;
using Back.Domain.Entities;

namespace Back.Application.Mappers
{
    public static class ProductMapper
    {
        public static IList<ProductResponse>? ListProductToListProductResponse(IList<Product> lstProduct)
        {
            if (lstProduct == null)
            {
                return null;
            }

            IList<ProductResponse> lstProductDTOs = new List<ProductResponse>();
            foreach (var item in lstProduct)
            {
                lstProductDTOs.Add(ProductToProductResponse(item));
            }

            return lstProductDTOs;
        }

        public static ProductResponse ProductToProductResponse(Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new ProductResponse()
            {
                id = product.id,
                name = product.name,
                id_category = product.id_category
            };
        }
    }
}

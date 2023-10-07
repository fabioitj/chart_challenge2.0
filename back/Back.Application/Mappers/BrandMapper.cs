using Back.Application.DTOs.Brand;
using Back.Domain.Entities;

namespace Back.Application.Mappers
{
    public static class BrandMapper
    {
        public static IList<BrandResponse>? ListBrandToListBrandResponse(IList<Brand> lstBrand)
        {
            if (lstBrand == null)
            {
                return null;
            }

            IList<BrandResponse> lstBrandDTOs = new List<BrandResponse>();
            foreach (var item in lstBrand)
            {
                lstBrandDTOs.Add(BrandToBrandResponse(item));
            }

            return lstBrandDTOs;
        }

        public static BrandResponse BrandToBrandResponse(Brand brand)
        {
            if (brand == null)
            {
                return null;
            }

            return new BrandResponse()
            {
                id = brand.id,
                name = brand.name,
                id_product = brand.id_product
            };
        }
    }
}

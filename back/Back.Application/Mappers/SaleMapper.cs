using Back.Application.DTOs.Sale;
using Back.Domain.Entities;

namespace Back.Application.Mappers
{
    public static class SaleMapper
    {
        public static IList<SaleResponse>? ListSaleToListSaleResponse(IList<Sale> lstSale)
        {
            if (lstSale == null)
            {
                return null;
            }

            IList<SaleResponse> lstSaleDTOs = new List<SaleResponse>();
            foreach (var item in lstSale)
            {
                lstSaleDTOs.Add(SaleToSaleResponse(item));
            }

            return lstSaleDTOs;
        }

        public static SaleResponse SaleToSaleResponse(Sale brand)
        {
            if (brand == null)
            {
                return null;
            }

            return new SaleResponse()
            {
                id = brand.id,
                month = brand.month,
                value = brand.value,
                id_brand = brand.id_brand
            };
        }
    }
}

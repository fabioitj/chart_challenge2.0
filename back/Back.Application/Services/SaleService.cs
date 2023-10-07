using Back.Application.DTOs.Sale;
using Back.Application.Interfaces;
using Back.Application.Mappers;
using Back.Domain.Interfaces;

namespace Back.Application.Services
{
    public class SaleService : ISaleService
    {
        private ISaleRepositoryAsync _saleRepositoryAsync;

        public SaleService(ISaleRepositoryAsync saleRepositoryAsync)
        {
            _saleRepositoryAsync = saleRepositoryAsync;
        }

        public async Task<IList<SaleResponse>> Get(SaleRequest saleRequest)
        {
            var lstAllBloodPressure = await _saleRepositoryAsync.Get(saleRequest.id_brand);

            if (lstAllBloodPressure == null || lstAllBloodPressure.Count == 0)
            {
                return null;
            }

            var response = SaleMapper.ListSaleToListSaleResponse(lstAllBloodPressure);
            return response;
        }
    }
}

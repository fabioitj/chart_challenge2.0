using Back.Application.DTOs.Brand;
using Back.Application.Interfaces;
using Back.Application.Mappers;
using Back.Domain.Interfaces;

namespace Back.Application.Services
{
    public class BrandService : IBrandService
    {
        private IBrandRepositoryAsync _brandRepositoryAsync;

        public BrandService(IBrandRepositoryAsync brandRepositoryAsync)
        {
            _brandRepositoryAsync = brandRepositoryAsync;
        }

        public async Task<IList<BrandResponse>>? Get(BrandRequest brandRequest)
        {
            var lstAllBloodPressure = await _brandRepositoryAsync.Get(brandRequest.id_product);

            if (lstAllBloodPressure == null || lstAllBloodPressure.Count == 0)
            {
                return null;
            }

            var response = BrandMapper.ListBrandToListBrandResponse(lstAllBloodPressure);
            return response;
        }
    }
}

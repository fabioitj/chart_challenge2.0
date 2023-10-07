using Back.Application.DTOs.Sale;

namespace Back.Application.Interfaces
{
    public interface ISaleService
    {
        Task<IList<SaleResponse>> Get(SaleRequest saleRequest);
    }
}


using DelearCosmosbd.domain.models;

namespace DelearCosmosbd.domain.services
{
    public interface IDealerMappingService
    {
        Task<IEnumerable<DealerMapping>> GetDealers();

        Task<IEnumerable<DealerMapping>> GetDealers(string vendorName);

        Task<IEnumerable<VendorSummary>> GetVendorSummary();

        Task<IEnumerable<DealerMapping>> GetDealersByCountry(string countryCode);

         Task<Dictionary<int, IEnumerable<DealerMapping>>> UpdateCbsMapping(string countryCode);
    }
}
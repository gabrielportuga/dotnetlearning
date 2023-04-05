using oasTools.domain.repository;
using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.service
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository vendorRepository;

        public VendorService(IVendorRepository vendorRepository)
        {
            this.vendorRepository = vendorRepository;
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            return this.vendorRepository.GetAllVendors();
        }

        // public IEnumerable<Vendor> GetAllVendors(int vendorId)
        // {
        //     return this.vendorRepository.GetAllVendors(vendorId);
        // }
    }
}
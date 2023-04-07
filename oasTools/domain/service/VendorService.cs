using OasTools.domain.repository;
using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.service
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
using oasTools.domain.repository;
using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return this.brandRepository.GetAllBrands();
        }

        // public IEnumerable<Brand> GetAllBrands(int vendorId)
        // {
        //     return this.brandRepository.GetAllBrands(vendorId);
        // }
    }
}
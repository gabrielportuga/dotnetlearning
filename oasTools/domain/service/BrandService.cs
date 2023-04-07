using OasTools.domain.repository;
using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.service
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
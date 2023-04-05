using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class VendorRepository : CommonRepository<RepositoryContext, Vendor>, IVendorRepository
    {
        private readonly RepositoryContext repository;

        public VendorRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        
        public IEnumerable<Vendor> GetAllVendors() =>
            FindAll().ToList();

    }
}
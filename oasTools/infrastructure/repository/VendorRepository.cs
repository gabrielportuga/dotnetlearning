using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.repository
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
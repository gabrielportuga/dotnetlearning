using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class BrandRepository : CommonRepository<RepositoryContext, Brand>, IBrandRepository
    {
        private readonly RepositoryContext repository;

        public BrandRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        public IEnumerable<Brand> GetAllBrands() =>
            FindAll()
            .OrderBy(c => c.brand_name)
            .ToList();

    }
}
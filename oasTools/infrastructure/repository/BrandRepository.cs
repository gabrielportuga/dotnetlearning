using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.repository
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
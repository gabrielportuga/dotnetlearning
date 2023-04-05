using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class CountryRepository : CommonRepository<RepositoryContext, Country>, ICountryRepository
    {
        private readonly RepositoryContext repository;

        public CountryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        public IEnumerable<Country> GetAllCountries() =>
            FindAll()
            .OrderBy(c => c.country_name)
            .ToList();

    }
}
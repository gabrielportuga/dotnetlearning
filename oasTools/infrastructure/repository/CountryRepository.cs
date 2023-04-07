using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.repository
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
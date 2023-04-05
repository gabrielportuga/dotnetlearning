using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class LanguageRepository : CommonRepository<RepositoryContext, Language>, ILanguageRepository
    {
        private readonly RepositoryContext repository;

        public LanguageRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        public IEnumerable<Language> GetAllLanguages() =>
            FindAll()
            .OrderBy(c => c.language_name)
            .ToList();

        public IEnumerable<Language> GetLanguages(int countryID)
        {
            return new List<Language>();
        }
    }
}
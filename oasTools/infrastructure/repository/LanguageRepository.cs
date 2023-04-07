using OasTools.infrastructure.repository;
using OasTools.infrastructure.repository.common;

namespace OasTools.domain.repository
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
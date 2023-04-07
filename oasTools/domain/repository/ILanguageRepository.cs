namespace OasTools.domain.repository
{
    public interface ILanguageRepository
    {
        public IEnumerable<Language> GetAllLanguages();

        public IEnumerable<Language>? GetLanguages(int countryId);
    }
}
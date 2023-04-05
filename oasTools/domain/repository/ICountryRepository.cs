namespace oasTools.domain.repository
{
    public interface ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries();
    }
}
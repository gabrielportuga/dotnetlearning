namespace oasTools.domain.repository
{
    public interface ICountriesRepository
    {
        public IEnumerable<Country> GetAllCountries();
    }
}
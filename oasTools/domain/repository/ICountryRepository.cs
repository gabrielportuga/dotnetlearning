namespace OasTools.domain.repository
{
    public interface ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries();
    }
}
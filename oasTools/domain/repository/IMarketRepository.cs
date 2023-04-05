namespace oasTools.domain.repository
{
    public interface IMarketRepository
    {
        public IEnumerable<Market> GetAllMarkets();

        public Market? GetMarket(int vendorId);

    }
}
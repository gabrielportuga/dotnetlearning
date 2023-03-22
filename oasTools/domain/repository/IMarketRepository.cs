namespace oasTools.domain.repository
{
    public interface IMarketRepository
    {
        public IEnumerable<Market> GetAllMarkets(bool trackChanges);

        public IEnumerable<Market> GetMarkets(int vendorId);

        public Market GetMarket(int vendorId);

        public int AddMarket(Market market);

        public int UpdateMarket(Market market);
    }
}
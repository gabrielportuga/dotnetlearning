namespace OasTools.domain.repository
{
    public interface IDealerRepository
    {
        public IEnumerable<Dealer> GetAllDealers();

        public IEnumerable<Dealer> GetAllDealers(int vendorId);

        public Dealer? GetDealer(int dealerId);

        public int AddDealer(Dealer dealer);

        public int UpdateDealer(Dealer dealer);
    }
}
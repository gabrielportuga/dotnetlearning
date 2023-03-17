namespace oasTools.domain.repository
{
    public interface IDealerRepository
    {
        public IEnumerable<Dealer> GetAllDealers(bool trackChanges);

        public Dealer? GetDealer(string email);

        public string AddDealer(Dealer dealer);

        public string UpdateDealer(Dealer dealer);
    }
}
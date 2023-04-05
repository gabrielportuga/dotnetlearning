using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class MarketRepository : CommonRepository<RepositoryContext, Market>, IMarketRepository
    {
        private readonly RepositoryContext repository;

        public MarketRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        public IEnumerable<Market> GetAllMarkets() =>
            FindAll().ToList();

        public Market? GetMarket(int vendorId) =>
            FindByCondition(c => c.vendor.id == vendorId).FirstOrDefault();

       
    }
}
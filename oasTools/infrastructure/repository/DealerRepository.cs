using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class DealerRepository : CommonRepository<RepositoryContext, Dealer>, IDealerRepository
    {
        private readonly RepositoryContext repository;

        public DealerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            this.repository = repositoryContext;
        }

        public int AddDealer(Dealer dealer)
        {
            try
            {
                Create(dealer);
                SaveChanges();
                return dealer.id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDealer(Dealer dealer)
        {
            try
            {
                Update(dealer);
                SaveChanges();
                return dealer.id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Dealer> GetAllDealers() =>
            FindAll()
            .OrderBy(c => c.dealer_name)
            .ToList();

        public Dealer? GetDealer(int dealer_id) =>
            FindByCondition(c => c.id == dealer_id).FirstOrDefault();

        public IEnumerable<Dealer> GetAllDealers(int vendorId)
        {
            return from vendor in this.repository.vendor
                   join market in this.repository.market on vendor.id equals market.vendor.id
                   join dealer in this.repository.dealer on market.id equals dealer.market.id
                   where vendor.id == vendorId
                   select dealer;
        }
    }
}
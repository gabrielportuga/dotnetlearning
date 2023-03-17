using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.repository
{
    public class DealerRepository : CommonRepository<RepositoryContext, Dealer>, IDealerRepository
    {
        public DealerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public string AddDealer(Dealer dealer)
        {
            try
            {
                Create(dealer);
                SaveChanges();
                return dealer.dealer_id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UpdateDealer(Dealer dealer)
        {
            try
            {
                Update(dealer);
                SaveChanges();
                return dealer.dealer_id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<Dealer> GetAllDealers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.dealer_name)
            .ToList();

        public Dealer? GetDealer(string dealer_id) =>
            FindByCondition(c => c.dealer_id == dealer_id, false).FirstOrDefault();
    }
}
using oasTools.domain.repository;
using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.service
{
    public class DomainDealerService : IDomainDealerService
    {
        private readonly IDealerRepository dealerRepository;

        public DomainDealerService(IDealerRepository dealerRepository)
        {
            this.dealerRepository = dealerRepository;
        }

        public string AddDealer(Dealer dealer)
        {
            try
            {
                var dealerResponse = this.dealerRepository.GetDealer(dealer.dealer_id);
                if (dealerResponse == null)
                    return this.dealerRepository.AddDealer(dealer);

                return "";
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
                var dealerResponse = this.dealerRepository.GetDealer(dealer.dealer_id);
                if (dealerResponse == null)
                    return this.dealerRepository.UpdateDealer(dealer);

                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Dealer> GetAllDealers(bool trackChanges)
        {
            return this.dealerRepository.GetAllDealers(false);
        }
    }
}
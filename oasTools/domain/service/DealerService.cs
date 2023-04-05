using oasTools.domain.repository;
using oasTools.infrastructure.repository;
using oasTools.infrastructure.repository.common;

namespace oasTools.domain.service
{
    public class DealerService : IDealerService
    {
        private readonly IDealerRepository dealerRepository;

        public DealerService(IDealerRepository dealerRepository)
        {
            this.dealerRepository = dealerRepository;
        }

        public int AddDealer(Dealer dealer)
        {
            try
            {
                var dealerResponse = this.dealerRepository.GetDealer(dealer.id);
                if (dealerResponse == null)
                    return this.dealerRepository.AddDealer(dealer);

                return 0;
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
                var dealerResponse = this.dealerRepository.GetDealer(dealer.id);
                if (dealerResponse == null)
                    return this.dealerRepository.UpdateDealer(dealer);

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Dealer> GetAllDealers()
        {
            return this.dealerRepository.GetAllDealers();
        }

        public IEnumerable<Dealer> GetAllDealers(int vendorId)
        {
            return this.dealerRepository.GetAllDealers(vendorId);
        }
    }
}
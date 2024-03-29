using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oasTools.domain.service
{
    public interface IDomainDealerService
    {
        public IEnumerable<Dealer> GetAllDealers();

        public IEnumerable<Dealer> GetAllDealers(int vendorId);

        public int AddDealer(Dealer dealer);

        public int UpdateDealer(Dealer dealer);
    }
}
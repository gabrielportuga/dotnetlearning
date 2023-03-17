using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oasTools.domain.service
{
    public interface IDomainDealerService
    {
        public IEnumerable<Dealer> GetAllDealers(bool trackChanges);

        public string AddDealer(Dealer dealer);

        public string UpdateDealer(Dealer dealer);
    }
}
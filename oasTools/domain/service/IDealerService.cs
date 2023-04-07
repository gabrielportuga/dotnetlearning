using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OasTools.domain.service
{
    public interface IDealerService
    {
        public IEnumerable<Dealer> GetAllDealers();

        public IEnumerable<Dealer> GetAllDealers(int vendorId);

        public int AddDealer(Dealer dealer);

        public int UpdateDealer(Dealer dealer);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OasTools.domain.service
{
    public interface IVendorService
    {
        public IEnumerable<Vendor> GetAllVendors();

       //public IEnumerable<Vendor> GetAllVendors(int vendorId);

    }
}
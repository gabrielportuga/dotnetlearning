using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OasTools.domain.service
{
    public interface IBrandService
    {
        public IEnumerable<Brand> GetAllBrands();

       //public IEnumerable<Brand> GetAllBrands(int brandId);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace users.domain.service
{
    public interface IDomainOrderService
    {
        Guid createUser(User user);

        User? getUser(Guid userId);
    }
}
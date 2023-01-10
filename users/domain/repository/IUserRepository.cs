using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace users.domain.repository
{
    public interface IUserRepository
    {
        User? findById(Guid id);

        void save(User user);
    }
}
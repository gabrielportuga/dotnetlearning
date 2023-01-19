using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace users.domain.service
{
    public interface IDomainUserService
    {
        public IEnumerable<User> GetAllUsers(bool trackChanges);

        public int AddUser(User user);
    }
}
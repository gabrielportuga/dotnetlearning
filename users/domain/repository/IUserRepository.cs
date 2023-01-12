using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users.domain.service;

namespace users.domain.repository
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers(bool trackChanges);
    }
}
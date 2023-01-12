using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users.domain.service;
using users.infrastructure.repository;
using users.infrastructure.repository.common;

namespace users.domain.repository
{
    public class UserRepository : CommonRepository<RepositoryContext, User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.name)
            .ToList();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users.domain.repository;

namespace users.domain.service
{
    public class DomainOrderService : IDomainOrderService
    {
        private readonly IUserRepository userRepository;

        public DomainOrderService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Guid createUser(User user)
        {
            throw new NotImplementedException();
        }

        public User? getUser(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
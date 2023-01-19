using users.domain.repository;
using users.infrastructure.repository;
using users.infrastructure.repository.common;

namespace users.domain.service
{
    public class DomainUserService : IDomainUserService
    {
        private readonly IUserRepository userRepository;

        public DomainUserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public int AddUser(User user)
        {
            try
            {
                return this.userRepository.AddUser(user);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {
            return this.userRepository.GetAllUsers(false);
        }
    }
}
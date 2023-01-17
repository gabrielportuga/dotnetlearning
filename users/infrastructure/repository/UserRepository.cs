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

        public int AddUser(User user)
        {
            try
            {
                Create(user);
                SaveChanges();
                return user.id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.name)
            .ToList();
    }
}
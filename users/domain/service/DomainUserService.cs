using users.domain.repository;
using users.infrastructure.repository;
using users.infrastructure.repository.common;

namespace users.domain.service
{
    public class DomainUserService : CommonRepository<RepositoryContext, User>, IDomainUserService
    {
        public DomainUserService(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.name)
            .ToList();
    }
}
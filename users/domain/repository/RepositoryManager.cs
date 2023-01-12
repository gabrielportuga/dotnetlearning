using users.infrastructure.repository;

namespace users.domain.repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext repositoryContext;
        private IUserRepository userRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public IUserRepository User
        {
            get
            {
                if (this.userRepository is null)
                    this.userRepository = new UserRepository(this.repositoryContext);

                return this.userRepository;
            }
        }

        public void Save() => this.repositoryContext.SaveChanges();
    }
}
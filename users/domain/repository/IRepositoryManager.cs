namespace users.domain.repository
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }

        void Save();
    }
}

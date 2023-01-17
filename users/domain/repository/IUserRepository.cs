namespace users.domain.repository
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers(bool trackChanges);

        public int AddUser(User user);
    }
}
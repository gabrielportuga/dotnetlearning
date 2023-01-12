using Microsoft.EntityFrameworkCore;
using users.domain;

namespace users.infrastructure.repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
        }

        public DbSet<User> user { get; set; }
    }
}
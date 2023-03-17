using Microsoft.EntityFrameworkCore;
using oasTools.domain;

namespace oasTools.infrastructure.repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        public DbSet<Dealer> dealer { get; set; }
    }
}
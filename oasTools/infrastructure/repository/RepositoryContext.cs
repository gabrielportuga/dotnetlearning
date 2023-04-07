using Microsoft.EntityFrameworkCore;
using OasTools.domain;

namespace OasTools.infrastructure.repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        public DbSet<Brand> brand { get; set; }
        public DbSet<Vendor> vendor { get; set; }
        public DbSet<Market> market { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Language> language { get; set; }
        public DbSet<Dealer> dealer { get; set; }
        public DbSet<DealerConfiguration> dealerConfiguration { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using OasTools.domain.repository;
using OasTools.domain.service;
using OasTools.infrastructure.repository;

namespace OasTools.infrastructure.configuration
{
    public static class PostgresConfiguration
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("dealerDbPostgres")));

    }
}
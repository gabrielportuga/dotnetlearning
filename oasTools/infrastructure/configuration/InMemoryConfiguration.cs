using Microsoft.EntityFrameworkCore;
using oasTools.domain.repository;
using oasTools.domain.service;
using oasTools.infrastructure.repository;

namespace oasTools.infrastructure.configuration
{
    public static class InMemoryConfiguration
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseInMemoryDatabase("dealerDbMemory"));

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IDomainDealerService, DomainDealerService>();
            services.AddScoped<IDealerRepository, DealerRepository>();
        }


    }
}
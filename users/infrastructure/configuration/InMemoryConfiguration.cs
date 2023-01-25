using Microsoft.EntityFrameworkCore;
using users.domain.repository;
using users.domain.service;
using users.infrastructure.repository;

namespace users.infrastructure.configuration
{
    public static class InMemoryConfiguration
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseInMemoryDatabase("UserDbMemory"));

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IDomainUserService, DomainUserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }


    }
}
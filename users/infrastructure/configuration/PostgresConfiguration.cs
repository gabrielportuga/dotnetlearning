using Microsoft.EntityFrameworkCore;
using users.domain.repository;
using users.infrastructure.repository;

namespace users.infrastructure.configuration
{
    public static class PostgresConfiguration
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("UserDbPostgres"), b => b.MigrationsAssembly("users")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
           services.AddScoped<IUserRepository, UserRepository>();
    }
}
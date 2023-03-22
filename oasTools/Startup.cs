
using Microsoft.AspNetCore.HttpOverrides;
using oasTools.infrastructure.configuration;

namespace oasTools
{
    public class Startup
    {
        public Startup(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
        }
        public IConfigurationRoot configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            PostgresConfiguration.ConfigureSqlContext(services, this.configuration);
            PostgresConfiguration.ConfigureRepositoryManager(services);
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
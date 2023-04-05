using Microsoft.EntityFrameworkCore;
using oasTools.domain.repository;
using oasTools.domain.service;
using oasTools.infrastructure.repository;

namespace oasTools.infrastructure.configuration
{
    public static class ConfigutationManager
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IDealerService, DealerService>();
            services.AddScoped<IDealerRepository, DealerRepository>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<IVendorService, VendorService>();
            services.AddScoped<IVendorRepository, VendorRepository>();
        }
    }
}
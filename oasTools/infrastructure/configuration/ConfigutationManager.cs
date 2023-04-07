using Microsoft.EntityFrameworkCore;
using OasTools.domain.repository;
using OasTools.domain.service;
using OasTools.infrastructure.repository;

namespace OasTools.infrastructure.configuration
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
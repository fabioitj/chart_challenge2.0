using Back.Application.Interfaces;
using Back.Application.Services;
using Back.Domain.Interfaces;
using Back.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Back.Infrastructure.IoC
{
    public class DependencyContainer
    {        
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepositoryAsync, BrandRepositoryAsync>();

            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<ISaleRepositoryAsync, SaleRepositoryAsync>();
        }
    }
}
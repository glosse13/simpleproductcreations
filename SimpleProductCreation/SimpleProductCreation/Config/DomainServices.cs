using Microsoft.Extensions.DependencyInjection;
using SimpleProductCreation.Core;
using SimpleProductCreation.Domain.Catalog.Interfaces;
using SimpleProductCreation.Domain.Catalog.Services;
using SimpleProductCreation.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductCreation.Config
{
    public static class DomainServices
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(DbContextRepository<>));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            return services;
        }
    }
}

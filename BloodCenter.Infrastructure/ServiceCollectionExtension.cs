using BloodCenter.Application.Repositories.Abstract;
using BloodCenter.Infrastructure.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodCenter.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IBloodTestRepository, BloodTestRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}

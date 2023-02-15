using Microsoft.Extensions.DependencyInjection;
using Milgot.Repositories.Interface;
using Milgot.Repositories.Interfaces;
using Milgot.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories
{
    public static class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildrenRepository, ChildrenRepository>();
            return services;
        }
    }
}

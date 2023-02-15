using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Milgot.Context;
using Milgot.Repositories;
using Milgot.Services.Interface;
using Milgot.Services.Interfaces;
using Milgot.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Services
{
    public static class Extension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddDbContext<IContext, MyDBContext>();
            services.AddRepositories();
            services.AddAutoMapper(typeof(Mapping));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildrenService, ChildrenService>();
            return services;
        }
    }
}

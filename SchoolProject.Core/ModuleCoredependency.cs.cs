using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Services.Apstract;
using SchoolProject.Services.Implementation;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoredependency
    {
        public static IServiceCollection AddCoredependency(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}

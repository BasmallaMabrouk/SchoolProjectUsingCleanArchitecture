using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Services.Apstract;
using SchoolProject.Services.Implementation;

namespace SchoolProject.Services
{
    public static class ModuleServicedependency
    {
        public static IServiceCollection AddServicedependency(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();

            return services;
        }
    }
}

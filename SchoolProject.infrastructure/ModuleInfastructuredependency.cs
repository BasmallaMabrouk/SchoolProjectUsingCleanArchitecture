using Microsoft.Extensions.DependencyInjection;
using SchoolProject.infrastructure.InfrastructureBases;
using SchoolProject.infrastructure.IRepositories;
using SchoolProject.infrastructure.Reposotories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrastructure
{
    public static class ModuleInfastructuredependency
    {
        public static IServiceCollection AddInfastructuredependency(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ERP.Application.Interfaces;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using ERP.PersistenceSQL.Repositories;
using ERP.PersistenceSQL.Repositories.ClienteRepositories;

namespace ERP.PersistenceSQL
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IClienteRepositoryAsync, ClienteRepositoryAsync>();
        }
    }
}
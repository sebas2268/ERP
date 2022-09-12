using ERP.Application.Interfaces;
using ERP.Application.Interfaces.Repositories.Maestras;
using ERP.Application.Interfaces.Repositories.PacienteRepositories;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.PersistenceSQL.Repositories;
using ERP.PersistenceSQL.Repositories.Maestras;
using ERP.PersistenceSQL.Repositories.PacienteRepositories;
using ERP.PersistenceSQL.Repositories.PersonaRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.PersistenceSQL
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IPersonaRepositoryAsync, PersonaRepositoryAsync>();
            services.AddTransient<IPacienteRepositoryAsync, PacienteRepositoryAsync>();
            services.AddTransient<IMaestraRepositoryAsync, MaestraRepositoryAsync>();
            services.AddTransient<IDataMaestraRepositoryAsync, DataMaestraRepositoryAsync>();
        }
    }
}
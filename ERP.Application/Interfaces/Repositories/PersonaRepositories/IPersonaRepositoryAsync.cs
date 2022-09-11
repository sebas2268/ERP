using ERP.Domain.DTOs.PersonasDto;
using ERP.Domain.Entities.PersonaEntities;

namespace ERP.Application.Interfaces.Repositories.PersonaRepositories
{
    public interface IPersonaRepositoryAsync : IGenericRepositoryAsync<Persona>
    {
        PersonaDto GetByIdentificacion(string identificacion);
        //Task<Persona> AddPersonaAsync(Persona cliente);
        //Task<Persona> UpdateClienteAsync(Persona cliente);
    }
}
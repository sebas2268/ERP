using ERP.Domain.DTOs.PacienteDto;
using ERP.Domain.Entities.PacienteEntities;

namespace ERP.Application.Interfaces.Repositories.PacienteRepositories
{
    public interface IPacienteRepositoryAsync : IGenericRepositoryAsync<Paciente>
    {
        PacienteDto GetByNmidPersona(int nmid_persona);
    }
}

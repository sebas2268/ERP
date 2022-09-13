using ERP.Domain.DTOs.PacienteDto;
using ERP.Domain.Entities.PacienteEntities;
using System.Collections.Generic;

namespace ERP.Application.Interfaces.Repositories.PacienteRepositories
{
    public interface IPacienteRepositoryAsync : IGenericRepositoryAsync<Paciente>
    {
        PacienteDto GetByNmidPaciente(int nmid_persona);
        IEnumerable<PacienteDto> GetPacientesDetalle();
    }
}

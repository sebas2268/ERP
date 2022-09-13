using AutoMapper;
using ERP.Application.Interfaces.Repositories.PacienteRepositories;
using ERP.Domain.DTOs.PacienteDto;
using ERP.Domain.Entities.PacienteEntities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ERP.PersistenceSQL.Repositories.PacienteRepositories
{
    public class PacienteRepositoryAsync : GenericRepositoryAsync<Paciente>, IPacienteRepositoryAsync
    {
        private readonly IMapper _mapper;
        public PacienteRepositoryAsync(SqlERPDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            _mapper = mapper;
        }

        public PacienteDto GetByNmidPaciente(int nmid_persona)
        {
            return _mapper.Map<PacienteDto>(_dbContext.TblPaciente
                    .Where(a => a.nmid_persona == nmid_persona)
                    .FirstOrDefault());
        }

        public IEnumerable<PacienteDto> GetPacientesDetalle()
        {
            return _mapper.Map<IEnumerable<PacienteDto>>(_dbContext.TblPaciente
                    .Include(p => p.nmidPersona)
                    .Include(p => p.nmidMedicotra));

        }

        public SqlERPDbContext SqlERPDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}

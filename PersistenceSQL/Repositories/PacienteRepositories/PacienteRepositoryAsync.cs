using AutoMapper;
using ERP.Application.Interfaces.Repositories.PacienteRepositories;
using ERP.Domain.DTOs.PacienteDto;
using ERP.Domain.Entities.PacienteEntities;
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

        public PacienteDto GetByNmidPersona(int nmid_persona)
        {
            return _mapper.Map<PacienteDto>(_dbContext.TblPaciente
                    .Where(a => a.nmid_persona == nmid_persona)
                    .FirstOrDefault());
        }

        public SqlERPDbContext SqlERPDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}

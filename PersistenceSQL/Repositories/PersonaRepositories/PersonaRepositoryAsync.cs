using AutoMapper;
using ERP.Application.Interfaces.Common.Dates;
using ERP.Application.Interfaces.Repositories.PersonaRepositories;
using ERP.Domain.DTOs.PersonasDto;
using ERP.Domain.Entities.PersonaEntities;
using System.Linq;

namespace ERP.PersistenceSQL.Repositories.PersonaRepositories
{
    public class PersonaRepositoryAsync : GenericRepositoryAsync<Persona>, IPersonaRepositoryAsync
    {
        private readonly IMapper _mapper;
        private readonly IMachineDateTime _machineDateTime;
        public PersonaRepositoryAsync(SqlERPDbContext dbContext, IMapper mapper, IMachineDateTime MachineDateTime) 
            : base(dbContext)
        {
            _mapper = mapper;
            _machineDateTime = MachineDateTime;
        }

        public PersonaDto GetByIdentificacion(string cddocumento)
        {
            return _mapper.Map<PersonaDto>(_dbContext.TblPersona
                    .Where(a => a.cddocumento == cddocumento)
                    .FirstOrDefault());
        }

        public SqlERPDbContext SqlSeguridadSocialdDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}

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

        //public async Task<Persona> AddClienteAsync(Persona cliente)
        //{
        //    var transaction = await _dbContext.Database.BeginTransactionAsync();
        //    try
        //    {
        //        await _dbContext.Set<Persona>().AddAsync(cliente);
        //        await _dbContext.SaveChangesAsync();

        //        //await _dbContext.Set<LogCliente>().AddAsync(_mapper.Map<LogCliente>(cliente));
        //        //await _dbContext.SaveChangesAsync();

        //        transaction.Commit();
        //        return cliente;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public PersonaDto GetByIdentificacion(string cddocumento)
        {
            return _mapper.Map<PersonaDto>(_dbContext.TblPersona
                    .Where(a => a.cddocumento == cddocumento)
                    .FirstOrDefault());
        }

        //public async Task<Persona> UpdateClienteAsync(Persona cliente)
        //{
        //    var transaction = await _dbContext.Database.BeginTransactionAsync();
        //    try
        //    {
        //        _dbContext.Update(cliente);
        //        await _dbContext.SaveChangesAsync();

        //        //await _dbContext.Set<LogCliente>().AddAsync(_mapper.Map<LogCliente>(cliente));
        //        //await _dbContext.SaveChangesAsync();

        //        transaction.Commit();
        //        return cliente;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public SqlERPDbContext SqlSeguridadSocialdDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}

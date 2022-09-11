using ERP.Application.Interfaces.Common.Dates;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;
using AutoMapper;
using ERP.Domain.DTOs.ClientesDto;
using ERP.Domain.Entities.ClienteEntities;
using System;
using System.Linq;
using System.Threading.Tasks;
using ERP.Persistence;

namespace ERP.PersistenceSQL.Repositories.ClienteRepositories
{
    public class ClienteRepositoryAsync : GenericRepositoryAsync<Cliente>, IClienteRepositoryAsync
    {
        private readonly IMapper _mapper;
        private readonly IMachineDateTime _machineDateTime;
        public ClienteRepositoryAsync(SqlERPDbContext dbContext, IMapper mapper, IMachineDateTime MachineDateTime) 
            : base(dbContext)
        {
            _mapper = mapper;
            _machineDateTime = MachineDateTime;
        }

        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                await _dbContext.Set<Cliente>().AddAsync(cliente);
                await _dbContext.SaveChangesAsync();

                //await _dbContext.Set<LogCliente>().AddAsync(_mapper.Map<LogCliente>(cliente));
                //await _dbContext.SaveChangesAsync();

                transaction.Commit();
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ClienteDto GetByIdentificacion(string identificacion)
        {
            return _mapper.Map<ClienteDto>(_dbContext.TblCliente
                    .Where(a => a.Identificacion == identificacion)
                    .FirstOrDefault());
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                _dbContext.Update(cliente);
                await _dbContext.SaveChangesAsync();

                //await _dbContext.Set<LogCliente>().AddAsync(_mapper.Map<LogCliente>(cliente));
                //await _dbContext.SaveChangesAsync();

                transaction.Commit();
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlERPDbContext SqlSeguridadSocialdDbContext
        {
            get { return _dbContext as SqlERPDbContext; }
        }
    }
}

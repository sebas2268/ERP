using ERP.Domain.DTOs.ClientesDto;
using ERP.Domain.Entities.ClienteEntities;
using System.Threading.Tasks;

namespace ERP.Application.Interfaces.Repositories.ClienteRepositories
{
    public interface IClienteRepositoryAsync : IGenericRepositoryAsync<Cliente>
    {
        ClienteDto GetByIdentificacion(string identificacion);
        Task<Cliente> AddClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);
    }
}
using Domain.DTOs.ClientesDto;
using MediatR;
using System.Collections.Generic;

namespace MovaltoSegurdidaSocial.Application.Features.ClienteFeatures.Clientes.Queries.GetAllClientes
{
    public class GetAllClientesQuery : IRequest<IEnumerable<ClienteDto>>
    {
    }
}

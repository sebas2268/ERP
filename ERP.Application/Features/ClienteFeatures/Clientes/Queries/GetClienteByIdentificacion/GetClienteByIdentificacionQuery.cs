using ERP.Domain.DTOs.ClientesDto;
using MediatR;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Queries.GetClienteByIdentificacion
{
    public class GetClienteByIdentificacionQuery : IRequest<ClienteDto>
    {
        public string Identificacion { get; set; }
        public GetClienteByIdentificacionQuery(string identificacion)
        {
            Identificacion = identificacion;
        }
    }
}
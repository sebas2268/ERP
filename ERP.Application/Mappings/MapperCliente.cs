using ERP.Application.Common.Dates;
using ERP.Application.Features.ClienteFeatures.Clientes.Commands.CreateCliente;
using ERP.Application.Features.ClienteFeatures.Clientes.Commands.UpdateCliente;
using AutoMapper;
using ERP.Domain.DTOs.ClientesDto;
using ERP.Domain.Entities.ClienteEntities;

namespace ERP.Application.Mappings
{
    public class MapperCliente : Profile
    {
        public MapperCliente()
        {
            var time = new MachineDateTime();
            CreateMap<Cliente, ClienteDto>();
            CreateMap<CreateClienteCommand, Cliente>()
                .ForMember(target => target.FechaRegistro, opt => opt.MapFrom(source => time.CentralStandardTime)); ;

            CreateMap<Cliente, UpdateClienteCommand>();
            CreateMap<UpdateClienteCommand, Cliente>().ForMember(source => source.Id, opt => opt.Ignore());
        }
    }
}

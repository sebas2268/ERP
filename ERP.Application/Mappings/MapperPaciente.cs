using AutoMapper;
using ERP.Application.Common.Dates;
using ERP.Application.Features.PacienteFeatures.Pacientes.Commands.CreatePaciente;
using ERP.Domain.DTOs.PacienteDto;
using ERP.Domain.Entities.PacienteEntities;

namespace ERP.Application.Mappings
{
    public class MapperPaciente : Profile
    {
        public MapperPaciente()
        {
            var time = new MachineDateTime();
            CreateMap<Paciente, PacienteDto>();
            CreateMap<CreatePacienteCommand, Paciente>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime));
        }
    }
}

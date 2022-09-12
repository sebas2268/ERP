using AutoMapper;
using ERP.Application.Common.Dates;
using ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra;
using ERP.Application.Features.PersonaFeatures.Personas.Commands.CreatePersona;
using ERP.Application.Features.PersonaFeatures.Personas.Commands.UpdatePersona;
using ERP.Domain.DTOs.Maestras;
using ERP.Domain.DTOs.PersonasDto;
using ERP.Domain.Entities.Maestras;
using ERP.Domain.Entities.PersonaEntities;

namespace ERP.Application.Mappings
{
    public class MapperMaestras : Profile
    {
        public MapperMaestras()
        {
            var time = new MachineDateTime();
            CreateMap<Maestra, MaestraDto>();
            CreateMap<DataMaestra, DataMaestraDto>();
            CreateMap<CreatePersonaCommand, Persona>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime))
                .ForAllMembers(opt => opt.Condition(src => src != null));

            CreateMap<CreateMaestraCommand, Maestra>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime))
                .ForAllMembers(opt => opt.Condition(src => src != null));

        }
    }
}

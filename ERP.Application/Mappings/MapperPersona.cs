using AutoMapper;
using ERP.Application.Common.Dates;
using ERP.Application.Features.PersonaFeatures.Personas.Commands.CreatePersona;
using ERP.Application.Features.PersonaFeatures.Personas.Commands.UpdatePersona;
using ERP.Domain.DTOs.PersonasDto;
using ERP.Domain.Entities.PersonaEntities;

namespace ERP.Application.Mappings
{
    public class MapperPersona : Profile
    {
        public MapperPersona()
        {
            var time = new MachineDateTime();
            CreateMap<Persona, PersonaDto>();
            CreateMap<CreatePersonaCommand, Persona>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime))
                .ForAllMembers(opt => opt.Condition(src => src != null));

            CreateMap<Persona, UpdatePersonaCommand>();
            CreateMap<UpdatePersonaCommand, Persona>().ForMember(source => source.nmid, opt => opt.Ignore());
        }
    }
}

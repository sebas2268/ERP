using AutoMapper;
using ERP.Application.Common.Dates;
using ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra;
using ERP.Application.Features.Maestras.Maestra_.Commands.CreateDataMaestra;
using ERP.Domain.DTOs.Maestras;
using ERP.Domain.Entities.Maestras;

namespace ERP.Application.Mappings
{
    public class MapperMaestras : Profile
    {
        public MapperMaestras()
        {
            var time = new MachineDateTime();
            CreateMap<Maestra, MaestraDto>();
            CreateMap<CreateMaestraCommand, Maestra>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime))
                .ForAllMembers(opt => opt.Condition(src => src != null));

            CreateMap<DataMaestra, DataMaestraDto>();
            CreateMap<CreateDataMaestraCommand, DataMaestra>()
                .ForMember(target => target.feregistro, opt => opt.MapFrom(source => time.CentralStandardTime))
                .ForAllMembers(opt => opt.Condition(src => src != null));

        }
    }
}

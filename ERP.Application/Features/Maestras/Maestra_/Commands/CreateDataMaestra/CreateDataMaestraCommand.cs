using MediatR;
using System;

namespace ERP.Application.Features.Maestras.Maestra_.Commands.CreateDataMaestra
{
    public class CreateDataMaestraCommand : IRequest<int>
    {
        public string nmmaestro { get; set; }
        public string nmdato { get; set; }

        #nullable enable
        public string? cddato { get; set; }
        public string? dsdato { get; set; }
        public string? cddato1 { get; set; }
        public string? cddato2 { get; set; }
        public string? cddato3 { get; set; }
        public DateTime? febaja { get; set; }
        #nullable disable
    }
}

using MediatR;
using System;

namespace ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra
{
    public class CreateMaestraCommand : IRequest<int>
    {
        public string nmmaestro { get; set; }

        #nullable enable
        public string? cdmaestro { get; set; }
        public string? dsmaestro { get; set; }
        public DateTime? febaja { get; set; }
        #nullable disable
    }
}

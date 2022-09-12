using MediatR;
using System;

namespace ERP.Application.Features.PacienteFeatures.Pacientes.Commands.CreatePaciente
{
    public class CreatePacienteCommand : IRequest<int>
    {
        public int nmid_persona { get; set; }
        public int nmid_medicotra { get; set; }
        public string? dseps { get; set; }
        public string? dsarl { get; set; }
        public DateTime? febaja { get; set; }
        public string? cdusuario { get; set; }
        public string? dscondicion { get; set; }
    }
}

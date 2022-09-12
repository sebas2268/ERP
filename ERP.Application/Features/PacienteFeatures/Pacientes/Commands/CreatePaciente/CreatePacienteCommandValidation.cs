using FluentValidation;

namespace ERP.Application.Features.PacienteFeatures.Pacientes.Commands.CreatePaciente
{
    public class CreatePacienteCommandValidation : AbstractValidator<CreatePacienteCommand>
    {
        public CreatePacienteCommandValidation()
        {
            RuleFor(p => p.nmid_persona)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.nmid_medicotra)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.dseps)
                .MaximumLength(60);

            RuleFor(p => p.dsarl)
                .MaximumLength(60);

            RuleFor(p => p.febaja);

            RuleFor(p => p.cdusuario)
                .MaximumLength(150);

            RuleFor(p => p.dscondicion);
        }
    }
}

using FluentValidation;

namespace ERP.Application.Features.PersonaFeatures.Personas.Commands.UpdatePersona
{
    public class UpdatePersonaCommandValidation : AbstractValidator<UpdatePersonaCommand>
    {
        public UpdatePersonaCommandValidation()
        {
            RuleFor(p => p.nmid)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.dsnombres)
                .NotNull()
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(60);

            RuleFor(p => p.dsapellidos)
                .MaximumLength(60);

            RuleFor(p => p.fenacimiento)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.cdtipo)
                .MaximumLength(10);

            RuleFor(p => p.cdgenero)
                .MaximumLength(10);

            RuleFor(p => p.febaja);

            RuleFor(p => p.cdusuario)
                .MaximumLength(150);

            RuleFor(p => p.dsdireccion)
                .MaximumLength(200);

            RuleFor(p => p.dsphoto)
                .MaximumLength(500);

            RuleFor(p => p.cdtelfono_fijo)
                .MaximumLength(20);

            RuleFor(p => p.cdtelefono_movil)
                .MaximumLength(20);

            RuleFor(p => p.dsemail)
                .MaximumLength(200);
        }
    }
}
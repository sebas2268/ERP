using FluentValidation;

namespace ERP.Application.Features.Maestras.DataMaestras.Commands.CreateMaestra
{
    public class CreateMaestraCommandValidation : AbstractValidator<CreateMaestraCommand>
    {
        public CreateMaestraCommandValidation()
        {
            RuleFor(p => p.nmmaestro)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(p => p.cdmaestro)
                .MaximumLength(5);

            RuleFor(p => p.dsmaestro)
                .MaximumLength(100);
        }
    }
}

using FluentValidation;

namespace ERP.Application.Features.Maestras.Maestra_.Commands.CreateDataMaestra
{
    public class CreateDataMaestraCommandValidation : AbstractValidator<CreateDataMaestraCommand>
    {
        public CreateDataMaestraCommandValidation()
        {
            RuleFor(p => p.nmmaestro)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(p => p.nmdato)
                .NotNull()
                .NotEmpty()
                .MaximumLength(150);

            RuleFor(p => p.cddato)
                .MaximumLength(20);

            RuleFor(p => p.dsdato)
                .MaximumLength(100);

            RuleFor(p => p.cddato1)
                .MaximumLength(100);

            RuleFor(p => p.cddato2)
                .MaximumLength(100);

            RuleFor(p => p.cddato3)
                .MaximumLength(100);
        }
    }
}

using FluentValidation;
using ERP.Application.Interfaces.Repositories.ClienteRepositories;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Commands.UpdateCliente
{
    public class UpdateClienteCommandValidation : AbstractValidator<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidation(IClienteRepositoryAsync clienteRepository)
        {
            RuleFor(p => p.Identificacion)
                .Matches("^[0-9]*$")
                .NotNull()
                .NotEmpty()
                .MinimumLength(4)
                .MaximumLength(30);

            RuleFor(p => p.Nombre)
                .NotNull()
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(100);

            RuleFor(p => p.SegundoNombre)
                .MaximumLength(30);

            RuleFor(p => p.PrimerApellido)
                .NotNull()
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(30);

            RuleFor(p => p.SegundoApellido)
                .MaximumLength(30);

            RuleFor(p => p.TelefonoContacto1)
                .Matches("^[0-9]*$")
                .NotNull()
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(10);

            RuleFor(p => p.TelefonoContacto2)
                .Matches("^[0-9]*$")
                .MaximumLength(10);

            RuleFor(p => p.CorreoElectronico)
                .NotNull()
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(60);

            RuleFor(p => p.FechaNacimiento)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.TipoDocumentoId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(p => p.UsuarioId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
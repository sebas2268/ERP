using MediatR;
using System;

namespace ERP.Application.Features.ClienteFeatures.Clientes.Commands.UpdateCliente
{
    public class UpdateClienteCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Identificacion { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TelefonoContacto1 { get; set; }
        public string TelefonoContacto2 { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumeroHijos { get; set; }
        public int TipoDocumentoId { get; set; }
        public bool Activo { get; set; }
        public int UsuarioId { get; set; }
    }
}

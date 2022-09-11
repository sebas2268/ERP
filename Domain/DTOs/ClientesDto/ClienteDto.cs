using System;

namespace ERP.Domain.DTOs.ClientesDto
{
    public class ClienteDto
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
        public DateTime FechaIngreso { get; set; }
        public int NumeroHijos { get; set; }
        public int TipoDocumentoId { get; set; }
        public int UsuarioId { get; set; }
        public bool Activo { get; set; }
    }
}
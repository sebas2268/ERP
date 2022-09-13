using ERP.Domain.DTOs.PersonasDto;
using System;

namespace ERP.Domain.DTOs.PacienteDto
{
    public class PacienteDto
    {
        public int nmid { get; set; }
        public int nmid_persona { get; set; }
        public int nmid_medicotra { get; set; }
        public string dseps { get; set; }
        public string dsarl { get; set; }
        public DateTime feregistro { get; set; }
        public DateTime febaja { get; set; }
        public string cdusuario { get; set; }
        public string dscondicion { get; set; }
        public PersonaDto nmidPersona { get; set; }
        public PersonaDto nmidMedicotra { get; set; }
    }
}

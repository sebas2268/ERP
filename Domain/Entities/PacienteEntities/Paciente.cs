using ERP.Domain.Entities.PersonaEntities;
using System;

namespace ERP.Domain.Entities.PacienteEntities
{
    public class Paciente
    {
        public int nmid { get; set; }
        public int nmid_persona { get; set; }
        public int nmid_medicotra { get; set; }
        public string dseps { get; set; }
        public string dsarl { get; set; }
        public DateTime ? feregistro { get; set; }
        public DateTime ? febaja { get; set; }
        public string cdusuario { get; set; }
        public string dscondicion { get; set; }
        public Persona nmidPersona { get; set; }
        public Persona nmidMedicotra { get; set; }
    }
}

﻿using System;

namespace ERP.Domain.Entities.PersonaEntities
{
    public class Persona
    {
        public int nmid { get; set; }
        public string cddocumento { get; set; }
        public string dsnombres { get; set; }
        public string dsapellidos { get; set; }
        public DateTime fenacimiento { get; set; }
        public string cdtipo { get; set; }
        public string cdgenero { get; set; }
        public DateTime feregistro { get; set; }
        public DateTime febaja { get; set; }
        public string cdusuario { get; set; }
        public string dsdireccion { get; set; }
        public string dsphoto { get; set; }
        public string cdtelfono_fijo { get; set; }
        public string cdtelefono_movil { get; set; }
        public string dsemail { get; set; }
    }
}
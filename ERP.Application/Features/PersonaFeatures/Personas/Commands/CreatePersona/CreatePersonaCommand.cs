﻿using MediatR;
using System;

namespace ERP.Application.Features.PersonaFeatures.Personas.Commands.CreatePersona
{
    public class CreatePersonaCommand : IRequest<int>
    {
        public string cddocumento { get; set; }
        public string dsnombres { get; set; }
        public DateTime fenacimiento { get; set; }

        #nullable enable
        public string? dsapellidos { get; set; }
        public string? cdtipo { get; set; }
        public string? cdgenero { get; set; }
        public DateTime? febaja { get; set; }
        public string? cdusuario { get; set; }
        public string? dsdireccion { get; set; }
        public string? dsphoto { get; set; }
        public string? cdtelfono_fijo { get; set; }
        public string? cdtelefono_movil { get; set; }
        public string? dsemail { get; set; }
        #nullable disable
    }
}

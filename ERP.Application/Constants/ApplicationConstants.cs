namespace ERP.Application.Constants
{
    public static class ApplicationConstants
    {
        public static class PersonaConstants
        {
            public static readonly string personaExiste = $"La persona ya se encuentra segistrada";
        }

        public static class PacienteConstants
        {
            public static readonly string pacienteExiste = $"El paciente ya se encuentra segistrado";
        }

        public static class MaestraConstants
        {
            public static readonly string maestraExiste = $"Ya existe maestro con el codigo ingresado";
        }

        public static class GeneralConstants
        {
            public static readonly string informacionNoEncontrada = $"No se encontró la información";
            public static readonly string errorRegistrandoInformacion = $"Ocurrió un error registrando la información";
            public static readonly string errorActualizandoInformacion = $"Ocurrió un error actualizando la información";
        }

    }
}

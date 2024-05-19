using _2024_1C_E_AgendaDeTurnos.Models;
using System;
namespace _2024_1C_E_AgendaDeTurnos.Helpers
{
	public static class Alias
	{
        /* FORMULARIO */
        public const string FormEmail = "Correl Electrónico";
        public const string FormNombre = "Nombre";
        public const string FormApellido = "Apellido";
        public const string FormLeido = "Estado Leído";
        public const string FormTitulo = "Título";
        public const string FormMensaje = "Mensaje";
        public const string FormUsuario = "Usuario";
        /* PACIENTE */
        public const string PacienteObraSoc = "Obra Social";
        public const string PacienteTurnos = "Turnos";
        /* PERSONA */
        public const string PersonaNombre = "Nombre";
        public const string PersonaApellido = "Apellido";
        public const string PersonaDni = "Nro. Documento";
        public const string PersonaTelefono = "Teléfono";
        public const string PersonaDireccion = "Dirección";
        public const string PersonaMail = "Email";
        public const string PersonaFA = "Fecha de Alta";
        /* PRESTACION */
        public const string PrestacionNombre = "Prestación";
        public const string PrestacionDescripcion = "Descripción";
        public const string PrestacionDuracion = "Duración";
        public const string PrestacionPrecio = "Precio";
        public const string PrestacionProfesionales = "Lista de profesionales";
        /* PROFESIONAL */
        public const string ProfesionalMatricula = "Nro. Matrícula";
        public const string ProfesionalHI = "Hora Inicio";
        public const string ProfesionalHF = "Hora Fin";
        public const string ProfesionalTurnos = "Listado de turnos";
        public const string ProfesionalPrestacion = "Prestación";
        /* TURNO */
        public const string TurnoFecha = "Fecha";
        public const string TurnoConfirmado = "Estado Confirmado";
        public const string TurnoActivo = "Estado Activo";
        public const string TurnoFA = "Fecha Alta";
        public const string TurnoCancelacion = "Motivo Cancelación";
        public const string TurnoPaciente = "Paciente";
        public const string TurnoProfesional = "Profesional";
        /* USUARIO */
        public const string UsuarioPass = "Contraseña";
    }
}


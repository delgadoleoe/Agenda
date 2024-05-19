using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public class Turno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.DateTime)]
        [Display(Name = Alias.TurnoFecha)]
        public DateTime Fecha { get; set; }

        [Display(Name = Alias.TurnoConfirmado)]
        public Boolean Confirmado { get; set; }

        [Display(Name = Alias.TurnoActivo)]
        public Boolean Activo { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.DateTime)]
        [Display(Name = Alias.TurnoFA)]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(400, MinimumLength = 2, ErrorMessage = ErrorMsgs.Longitud)]
        [Display(Name = Alias.TurnoCancelacion)]
        public string DescripcionCancelacion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int PacienteId { get; set; }
        [Display(Name = Alias.TurnoPaciente)]
        public Paciente Paciente { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int ProfesionalId { get; set; }
        [Display(Name = Alias.TurnoProfesional)]
        public Profesional Profesional { get; set; }

    }
}
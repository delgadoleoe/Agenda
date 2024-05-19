using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public abstract class Profesional : Persona
    {

        public int Id { get; set; }

        [StringLength(Restrictions.CeilMatricula, MinimumLength = 1, ErrorMessage = ErrorMsgs.Longitud)]
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.ProfesionalMatricula)]
        public int Matricula { get; set; }

        [StringLength(10, MinimumLength = 4, ErrorMessage = ErrorMsgs.Longitud)]
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.ProfesionalHI)]
        public string HoraInicio { get; set; }

        [StringLength(10, MinimumLength = 4, ErrorMessage = ErrorMsgs.Longitud)]
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.ProfesionalHF)]
        public string HoraFin { get; set; }

        [Display(Name = Alias.ProfesionalTurnos)]
        public List<Turno> Turnos { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int PrestacionId { get; set; }
        public Prestacion Prestacion { get; set; }
    }
}
using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public class Paciente : Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilObraSocial, MinimumLength = Restrictions.FloorObraSocial, ErrorMessage = ErrorMsgs.Longitud)]
        [Display(Name = Alias.PacienteObraSoc)]
        public string ObraSocial { get; set; }
        [Display(Name = Alias.PacienteTurnos)]

        public List<Turno> Turnos { get; set; }
    }
}
using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public class Usuario : Persona
    {
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = ErrorMsgs.Longitud)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,100}$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial")]
        [Display(Name = Alias.UsuarioPass)]
        public string Password { get; set; }
    }
}
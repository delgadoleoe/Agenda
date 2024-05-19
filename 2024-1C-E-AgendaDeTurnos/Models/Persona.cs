using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;


namespace _2024_1C_E_AgendaDeTurnos.Models

{
    public abstract class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilApellidoNombre, MinimumLength = Restrictions.FloorApellidoNombre, ErrorMessage = ErrorMsgs.Longitud)]
        [RegularExpression("[a-zA-ZÒ—·ÈÌÛ˙¡…Õ”⁄]*", ErrorMessage = ErrorMsgs.SoloLetras)]
        [Display(Name = Alias.PersonaNombre)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilApellidoNombre, MinimumLength = Restrictions.FloorApellidoNombre, ErrorMessage = ErrorMsgs.Longitud)]
        [RegularExpression("[a-zA-ZÒ—·ÈÌÛ˙¡…Õ”⁄]*", ErrorMessage = ErrorMsgs.SoloLetras)]
        [Display(Name = Alias.PersonaApellido)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilDNI, MinimumLength = Restrictions.FloorDNI, ErrorMessage = ErrorMsgs.MaxCaracteres)]
        [RegularExpression("^[0-9]*$", ErrorMessage = ErrorMsgs.SoloNumeros)]
        [Display(Name = Alias.PersonaDni)]
        public string DNI { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [RegularExpression(@"^\d{7,15}$", ErrorMessage = "Formato inv·lido. El TelÈfono debe contener entre 7 y 15 dÌgitos")]
        [Display(Name = Alias.PersonaTelefono)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = ErrorMsgs.Longitud)]
        [Display(Name = Alias.PersonaDireccion)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [EmailAddress(ErrorMessage = ErrorMsgs.Email)]
        [Display(Name = Alias.PersonaMail)]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.DateTime)]
        [Display(Name = Alias.PersonaFA)]
        public DateTime FechaAlta { get; set; }

        public string NombreCompleto { get { return Nombre + " " + Apellido; } }
    }
}
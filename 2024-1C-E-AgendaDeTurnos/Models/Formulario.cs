using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public class Formulario
    {
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [EmailAddress(ErrorMessage = ErrorMsgs.Email)]
        [Display(Name = Alias.FormEmail)]
        public string Email {  get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilApellidoNombre, MinimumLength = Restrictions.FloorApellidoNombre, ErrorMessage = ErrorMsgs.Longitud)]
        [RegularExpression("[a-zA-ZñÑáéíóúÁÉÍÓÚ]*", ErrorMessage = ErrorMsgs.SoloLetras)]
        [Display(Name = Alias.FormNombre)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(Restrictions.CeilApellidoNombre, MinimumLength = Restrictions.FloorApellidoNombre, ErrorMessage = ErrorMsgs.Longitud)]
        [RegularExpression("[a-zA-ZñÑáéíóúÁÉÍÓÚ]*", ErrorMessage = ErrorMsgs.SoloLetras)]
        [Display(Name = Alias.FormApellido)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.FormLeido)]
        public bool Leido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [MaxLength(100, ErrorMessage = ErrorMsgs.MaxCaracteres)]
        [Display(Name = Alias.FormTitulo)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [MaxLength(Restrictions.CeilDescripcionNotas, ErrorMessage = ErrorMsgs.MaxCaracteres)]
        [Display(Name = Alias.FormMensaje)]
        public string Mensaje { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]

        public int UsuarioId { get; set; }
        [Display(Name = Alias.FormUsuario)]
        public Usuario Usuario { get; set; }

        Formulario()
        {
           
        }

        Formulario(DateTime Fecha, string Email, string Nombre, string Apellido, bool Leido, string Titulo, string Mensaje, Usuario Usuario)
        {
            this.Fecha = Fecha;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Titulo = Titulo;
            this.Leido = Leido;
            this.Mensaje = Mensaje;
            this.Usuario = Usuario;
            this.Email = Email;
        }
    }
}

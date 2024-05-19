using _2024_1C_E_AgendaDeTurnos.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2024_1C_E_AgendaDeTurnos.Models
{
    public class Prestacion
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.Longitud)]
        [Display(Name = Alias.PrestacionNombre)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [MaxLength(Restrictions.CeilDescripcionNotas, ErrorMessage = ErrorMsgs.MaxCaracteres)]
        [Display(Name = Alias.PrestacionDescripcion)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [RegularExpression("^[0-9]*$", ErrorMessage = ErrorMsgs.SoloNumeros)]
        [Display(Name = Alias.PrestacionDuracion)]
        public int Duracion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.PrestacionPrecio)]
        public decimal Precio { get; set; }

        [Display(Name = Alias.PrestacionProfesionales)]
        public List<Profesional> Profesionales { get; set; }

        public Prestacion(int Id, string Nombre, string Descripcion, int Duracion, decimal Precio)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
            this.Precio = Precio;
            this.Profesionales = new List<Profesional>();
        }
        public Prestacion()
        {

        }
    }
}
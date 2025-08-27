using System.ComponentModel.DataAnnotations;
namespace CrudNativoBiblioteca.Models
{
    public class Libro
    {
        [Key] //Llave primaria
        public int Id { get; set; } //propiedades

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Título del libro")] //aparezca con tilde
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Precio { get; set; }
    }
}

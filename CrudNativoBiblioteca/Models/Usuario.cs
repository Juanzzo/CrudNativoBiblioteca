using System.ComponentModel.DataAnnotations;
using System;

namespace CrudNativoBiblioteca.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caracteres")]
        [Display(Name = "Número de Teléfono")]
        public string NumeroTelefono { get; set; }
    }
}

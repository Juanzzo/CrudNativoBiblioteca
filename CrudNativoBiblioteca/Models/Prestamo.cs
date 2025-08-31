using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudNativoBiblioteca.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Libro")]
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Inicio del Préstamo")]
        public DateTime FechaInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Fin del Préstamo")]
        public DateTime FechaFin { get; set; }
    }
}

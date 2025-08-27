using CrudNativoBiblioteca.Models;//Llamamos el modelo
using Microsoft.EntityFrameworkCore;
namespace CrudNativoBiblioteca.Data

{
    public class AplicationDbContext : DbContext

    {   
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) //creamos el constructor
        {
        }
        public DbSet<Libro> Libros { get; set; } //Representa una coleccion de todas las entidades en el contexto o que pueden ser consultadas desde la base de datos
    }
}

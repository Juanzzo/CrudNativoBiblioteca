using CrudNativoBiblioteca.Data;
using CrudNativoBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudNativoBiblioteca.Controllers
{
    public class LibrosController : Controller
    {
        private readonly AplicationDbContext _context; //invocamos para acceder a la base de datos

        //creamos el constructor
        public LibrosController(AplicationDbContext context)
        {
               _context = context;
        }
        public IActionResult Index()
        {
            //creamos una lista
            IEnumerable<Libro> Listlibros = _context.Libros;
            return View(Listlibros); //Para que retome la lista
        }
        //Http Get Create
        public IActionResult Create()
        {
            return View();

        }

        //Http Get Post
        [HttpPost]
        public IActionResult Create(Libro libro) 
            {
                if (ModelState.IsValid) 
                    {
                        _context.Libros.Add(libro);
                        _context.SaveChanges();

                TempData["Mensaje"] = " Libro Registrado Con Exito ";

                        return RedirectToAction("Index");
                    }
                    return View();
            }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if ( id==)
        }
    }
}


using CrudNativoBiblioteca.Data;
using CrudNativoBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CrudNativoBiblioteca.Controllers
{
    public class PrestamosController : Controller
    {
        private readonly AplicationDbContext _context;

        public PrestamosController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var prestamos = _context.Prestamos
                .Select(p => new Prestamo {
                    Id = p.Id,
                    LibroId = p.LibroId,
                    Libro = p.Libro,
                    UsuarioId = p.UsuarioId,
                    Usuario = p.Usuario,
                    FechaInicio = p.FechaInicio,
                    FechaFin = p.FechaFin
                }).ToList();
            return View(prestamos);
        }
        public IActionResult Create()
        {
            ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo");
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Prestamos.Add(prestamo);
                _context.SaveChanges();
                TempData["Mensaje"] = "Préstamo registrado con éxito";
                return RedirectToAction("Index");
            }
            ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var prestamo = _context.Prestamos.Find(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        [HttpPost]
        public IActionResult Edit(Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Prestamos.Update(prestamo);
                _context.SaveChanges();
                TempData["Mensaje"] = "Préstamo editado con éxito";
                return RedirectToAction("Index");
            }
            ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var prestamo = _context.Prestamos.Find(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            return View(prestamo);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var prestamo = _context.Prestamos.Find(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            _context.Prestamos.Remove(prestamo);
            _context.SaveChanges();
            TempData["Mensaje"] = "Préstamo eliminado con éxito";
            return RedirectToAction("Index");
        }
    }
}

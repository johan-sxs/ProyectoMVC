using Microsoft.AspNetCore.Mvc;
using Peli.Core;
using Peli.MVC.ViewModels;

namespace Peli.Controllers
{
    public class PeliculaController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        => View(Repositorio.Peliculas);

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var Pelicula = Repositorio.GetPelicula(id);
            if (Pelicula is null)
            {
                return NotFound();
            }
            return View(Pelicula);
        }
        [HttpGet]

        public IActionResult FormAlta(int? idGenero)
         {
            var vmPelicula= new VMPelicula(Repositorio.Generos)
            {
               IdGeneroSeleccionado = idGenero
            };
            return View(vmPelicula);
        }

        [HttpPost]

        public IActionResult FormAlta(Pelicula pelicula)
        {
            Repositorio.AgregarPelicula(pelicula);
            return View("index", Repositorio.Peliculas);
        }
    }
}
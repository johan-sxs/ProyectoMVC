using Microsoft.AspNetCore.Mvc;
using Peli.Core;

namespace Peli.Controllers
{
    public class GeneroController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        => View(Repositorio.Generos);

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var Genero = Repositorio.GetGenero(id);
            if (Genero is null)
            {
                return NotFound();
            }
            return View(Genero);
        }
        [HttpGet]

        public IActionResult FormAlta() => View();

        [HttpPost]

        public IActionResult FormAlta(Genero genero)
        {
            Repositorio.AgregarGenero(genero);
            return View("index", Repositorio.Generos);
        }

    }
}
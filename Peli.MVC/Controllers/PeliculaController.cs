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

        public IActionResult FormAlta(int? idGenero , int idProductora)
         {
            var vmPelicula= new VMPelicula(Repositorio.Generos , Repositorio.Productoras)
            {
               IdGeneroSeleccionado = idGenero
            };
            return View(vmPelicula);
        }


        [HttpPost]

        public IActionResult FormAlta(VMPelicula vMPelicula)
        {
             var genero = Repositorio.GetGenero(vMPelicula.IdGeneroSeleccionado.Value);
             var productora = Repositorio.GetProductora(vMPelicula.IdProductoraSeleccionado);
             vMPelicula.Pelicula.genero = genero;
             vMPelicula.Pelicula.productora = productora;
             Repositorio.AgregarPelicula(vMPelicula.Pelicula);
             return View("Index",Repositorio.Peliculas);

             
    }
    
}
}
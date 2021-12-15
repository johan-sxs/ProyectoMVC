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
            var pelicula = Repositorio.GetPelicula(id);
            if (pelicula is null)
            {
                return NotFound();
            }
            return View(pelicula);
        }
        [HttpGet]

        public IActionResult FormAlta(int? idGenero , int? idProductora)
         {
            var vmPelicula= new VMPelicula(Repositorio.Generos, Repositorio.Productoras )
            {
               IdGeneroSeleccionado = idGenero,
               IdProductoraSeleccionada = idProductora
            };
            return View(vmPelicula);
        }


        [HttpPost]

        public IActionResult FormAlta(VMPelicula vMPelicula)
        {
             var genero = Repositorio.GetGenero(vMPelicula.IdGeneroSeleccionado.Value);
             var prductora = Repositorio.GetProductora(vMPelicula.IdProductoraSeleccionada.Value);
             vMPelicula.Pelicula.genero = genero;
             vMPelicula.Pelicula.productora=prductora;
             Repositorio.AgregarPelicula(vMPelicula.Pelicula);
             genero.AgregarPelicula(vMPelicula.Pelicula);
            prductora.AgregarPelicula(vMPelicula.Pelicula);
             return View("Index",Repositorio.Peliculas);

             
    }
    
}
}
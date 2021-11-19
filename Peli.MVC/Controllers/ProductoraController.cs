using Microsoft.AspNetCore.Mvc;
using Peli.Core;

namespace Peli.Controllers
{
    public class ProductoraController : Controller
    {
        [HttpGet]
      
      public ActionResult Index()
      => View(Repositorio.Productoras);

[HttpGet]
public IActionResult Detalle(int id)
{
    var Productora = Repositorio.GetProductora(id);
    if(Productora is null)
    {
        return NotFound();
    }
    return View(Productora);
}
[HttpGet]
 public IActionResult FormAlta() => View();

        [HttpPost]

        public IActionResult FormAlta(Productora productora)
        {
            Repositorio.AgregarProductora(productora);
            return View("index", Repositorio.Productoras);
        }
    }
}
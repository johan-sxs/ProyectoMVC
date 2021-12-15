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
    var productora = Repositorio.GetProductora(id);
    if(productora is null)
    {
        return NotFound();
    }
    return View(productora);
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
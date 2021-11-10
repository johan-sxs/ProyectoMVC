using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Peli.MVC.Models;

namespace Peli.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult index()
        {
            return View();
        }
    }}
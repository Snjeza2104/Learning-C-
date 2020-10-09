using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt05_02.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: Kalkulator
        public ViewResult Izracunaj()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Izracunaj(double a, double b, string z)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            return View((object)z);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_4_1_vj.Controllers
{
    public class BrojGodinaController : Controller
    {
        // GET: BrojGodina
        public ViewResult RacunajBrojGodina()
        {
            return View("RacunajBrojGodina");
        }
        [HttpPost]
        public ViewResult RacunajBrojGodina(DateTime datum)
        {
            try { 
            int ukupno = (DateTime.Now - datum).Days/365; 
            return View("RacunajBrojGodina", (object)ukupno.ToString());
            }
            catch (Exception e)
            {
                return View((object)e.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_4_2_vj.Models;

namespace projekt_4_2_vj.Controllers
{
    public class NaruciArtikalController : Controller
    {
        // GET: NaruciArtikal
        public ViewResult NaruciArtikal()
        {
            return View(new Artikl());
        }
        [HttpPost]
        public ViewResult NaruciArtikal(Artikl artikal)
        {
            string poruka = "";
            if (artikal.Kolicina > 10)
            {
                ViewBag.poruka = "Nedovoljna količina na skladištu.";
            }
            else
            {
                ViewBag.poruka = "Uspješna narudžba artikla. " + artikal.Kolicina + " komada " + artikal.Naziv + " s ukupnom cijenom " + artikal.Cijena * artikal.Kolicina+" kn.";
            }
            return View(artikal);
        }
    }
}
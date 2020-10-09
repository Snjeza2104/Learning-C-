using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_5_5_vj.Models;

namespace projekt_5_5_vj.Controllers
{
    public class PrikazSaChildAkcijomController : Controller
    {
        // GET: PrikazSaChildAkcijom
        public ViewResult ObradiListu()
        {
            List<Artikl> lArtikl = new List<Artikl>()
            {
                new Artikl(){Naziv="Kruh", Cijena=8.9m, Kolicina=3, Kategorija="kruh"},
                new Artikl(){Naziv="Sir", Cijena=54.7m, Kolicina=1, Kategorija="namirnica"},
                new Artikl(){Naziv="Mlijeko", Cijena=6.5m, Kolicina=1, Kategorija="mlijeko"}

            };
            return View(lArtikl);
        }

        [ChildActionOnly]
        public string OdrediKategoriju(Artikl artikl)
        {
            return artikl.Kategorija;
        }
    }
}
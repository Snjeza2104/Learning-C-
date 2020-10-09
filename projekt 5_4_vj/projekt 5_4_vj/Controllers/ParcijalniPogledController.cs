using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_5_4_vj.Models;

namespace projekt_5_4_vj.Controllers
{
    public class ParcijalniPogledController : Controller
    {
        // GET: ParcijalniPogled
        public ViewResult ObradiListu()
        {
            List<Artikl> lArtikl = new List<Artikl>()
            {
                new Artikl(){Naziv="Kruh" , Cijena=8 ,Kolicina=1},
                new Artikl(){Naziv="Mlijeko" , Cijena=4 ,Kolicina=2},
                new Artikl(){Naziv="Majica" , Cijena=20.50m ,Kolicina=5},
                new Artikl(){Naziv="Hlače" , Cijena=49.90m , Kolicina=7},
                new Artikl(){Naziv="Cipele" , Cijena=299.99m ,Kolicina=1}
            };
            return View(lArtikl);
        }
    }
}
/*Kreirajte novi MVC projekt 3_2_vj i u njemu dodajte kontroler GeneratorIzlazaController.
 Nakon toga implementirajte metodu PopisKosarice, koja će vratiti view istog naziva kao i metoda,
te u njemu prikažite proizvoljne podatke o nazivu artikla i cijeni u HTML elementu <table>.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*U kontroleru iz prethodnog zadatka dodajte metodu ListaArtikala koja će proslijediti u view
 podatke o različitim artiklima preko ViewBag objekta. U pregledniku se trebaju prikazati
artikli u obliku nenumerirane liste.*/


/*U kontroleru iz prethodnog zadatka GeneratorIzlazaController dodajte metodu naziva
 RedirectNaMetodu s parametrom id tipa string. U slučaju da je vrijednost parametra
id jednaka "Kosarica", metoda treba vraćati view PopisKosarice, a u ostalim
slučajevima view ListaArtikala.*/

namespace projekt_3_2_vj.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GET: GeneratorIzlaza
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult PopisKosarice()
        {
            return View();
        }

        public ActionResult ListaArtikala()
        {
            string[] lista = new string[] { "Skije", "Pancerice", "Sunčane naočale", "Šal", "Kapa" };
            ViewBag.Lista = lista;
            return View();
        }

        public RedirectResult RedirectNaMetodu (string id)
        {
            if (id == "Kosarica")
                return Redirect("/GeneratorIzlaza/PopisKosarice");
            else
                return Redirect("/GeneratorIzlaza/ListaArtikala");
        }

    }
}
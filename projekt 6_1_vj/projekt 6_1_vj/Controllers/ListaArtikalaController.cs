using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt_6_1_vj.Models;

namespace projekt_6_1_vj.Controllers
{
    public class ListaArtikalaController : Controller
    {
        string[] kategorija = new string[] {"Hrana", "Kućanstvo", "Vrt", "Rekreacija" };
        // GET: ListaArtikala
        public ViewResult UnesiArtikl()
        {

            ViewBag.Kategorija = kategorija;
            return View(new Artikl());
        }

        [HttpPost]
        public ViewResult DodajArtikl(Artikl artikl)
        {
           if (Session["Artikli"] != null)
            {
                List<Artikl> artikli = (List<Artikl>)Session["Artikli"];
                artikli.Add(artikl);
                Session["Artikli"] = artikli;
            }
            else
            {
                List<Artikl> artikli = new List<Artikl>();
                artikli.Add(artikl);
                Session["Artikli"] = artikli;
            }
            return View(Session["Artikli"]);
        }
    }
}
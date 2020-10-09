using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt_4_1_vj.Controllers
{
    public class TocanOdgovorController : Controller
    {
        // GET: TocanOdgovor
       public ViewResult ProvjeriOdgovor()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ProvjeriOdgovor(string odgovor)
        {
            string poruka = "";
            if (!string.IsNullOrEmpty(odgovor))
            {
                if (odgovor == "a")
                {
                    poruka = "Odgovor je točan.";
                    return View((object)poruka);
                }
                else
                {
                    poruka = "Odgovor nije točan.";
                    return View((object)poruka);
                }
            }
            else
            {
                poruka = "Odgovor ne postoji.";
                return View((object)poruka);
            }
            
        }
    }
}
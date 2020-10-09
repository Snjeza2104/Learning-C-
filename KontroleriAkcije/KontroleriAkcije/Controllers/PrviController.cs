using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KontroleriAkcije.Controllers
{
    public class PrviController : Controller
    {
        public string Pozdrav()
        {
            return "Pozdrav s prvog kontrolera!";
        }

        public string KontekstniPodaci()
        {
            string serverName = Server.MachineName;
            DateTime dateStamp = HttpContext.Timestamp;
            return "<h2>Kontekstni podaci iz zahtjeva:</h2>"
                + "<ul>" +
                "<li>" + serverName + "</li>" +
                "<li>" + dateStamp.ToString() + "</li>" +
                "</ul>";
        }

        public string MetodaSaParametrima(string id)
        {
            return "Pozdrav " + id + "!";
        }

        public string MetodaSaParametrima2(int? id)
        {
            return "Pozdrav " + id.ToString() + "!";
        }
        public string MetodaSaParametrima3(int id=2015)
        {
            return "Pozdrav " + id.ToString() + "!";
        }
    }
}
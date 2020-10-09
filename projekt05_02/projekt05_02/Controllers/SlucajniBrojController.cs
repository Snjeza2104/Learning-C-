using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;


namespace projekt05_02.Controllers
{
    public class SlucajniBrojController : Controller
    {
        private readonly Random _random = new Random();
        // GET: SlucajniBroj
        public ViewResult RazvrstajSlucajniBroj()
        {
            int broj = _random.Next(1,1000);

            return View(broj);
        }
    }
}
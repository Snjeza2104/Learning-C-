using HtmlHelperi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperi.Controllers
{
    public class MetaDatahtmlHelperiController : Controller
    {
        // GET: MetaDatahtmlHelperi
        public ViewResult MetaDataView()
        {
            return View(new OsobaMeta());
        }

        [HttpPost]
        public ViewResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }

        public ViewResult MetaDataView2()
        {
            return View(new OsobaMeta());
        }

        [HttpPost]
        public ViewResult MetaDataView2(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt05_02.Controllers
{
    public class LayoutPoglediController : Controller
    {
        // GET: LayoutPogledi
        public ViewResult LayoutPogled()
        {
            return View();
        }

        public ViewResult LayoutSectionPogled()
        {
            return View();
        }
    }
}
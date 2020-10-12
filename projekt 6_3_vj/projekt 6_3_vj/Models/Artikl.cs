using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace projekt_6_3_vj.Models
{
    
    public class Artikl
    {
        [UIHint("TemplateKategorija")]
        public string Kategorija { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }

        [Display(Name ="Količina")]
        public int Kolicina { get; set; }
    }
}

using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LINQ_upiti_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba { Ime = "Mirko", Prezime = "Spirko" });
            osobe.Add(new Osoba { Ime = "Jura", Prezime = "Klafura" });
            osobe.Add(new Osoba { Ime = "Snježa", Prezime = "Beža" });

            Osoba trazenaOsoba = (from os in osobe where os.Prezime == "Spirko" select os).SingleOrDefault();
            Console.WriteLine(trazenaOsoba.Ime+" "+trazenaOsoba.Prezime);

            List<Osoba> trazeneOsobe = (from os in osobe orderby os.Prezime where os.Prezime=="Spirko" 
                                        || os.Prezime.Contains("Klaf") select os).ToList();
            foreach(Osoba osoba in trazeneOsobe)
            {
                Console.WriteLine(osoba.Ime + " " + osoba.Prezime);
            }
        }
    }
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}

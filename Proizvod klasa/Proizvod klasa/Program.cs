using System;

namespace Proizvod_klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod();
            proizvod.NaIzracunCijene += new Proizvod.NaIzracunCijeneDelegat(proizvod_NaIzracunCijene);
            Console.Write("Unesite naziv proizvoda: ");
            proizvod.naziv = Console.ReadLine();
            Console.Write("Unesite osnovnu cijenu proizvoda: ");
            proizvod.osnovnacijena = double.Parse(Console.ReadLine());
            Console.Write("Unesite meržu iz intervala [0,1]");
            proizvod.marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Cijena je: {0}", proizvod.IzracunajCijenu());

           
        }
        static void proizvod_NaIzracunCijene(object sender, EventArgs e)
        {
            Proizvod proizvod = (Proizvod)sender;
            Console.WriteLine("Izračunata je ukupna cijena proizvoda {0}.", proizvod.naziv);
        }
        class Proizvod
        {
            public delegate void NaIzracunCijeneDelegat(object sender, EventArgs e);
            public event NaIzracunCijeneDelegat NaIzracunCijene;
            private string Naziv;
            public string naziv
            {
                get { return Naziv; }
                set { Naziv = value; }
            }
            private double OsnovnaCijena;
            public double osnovnacijena
            {
                get { return OsnovnaCijena; }
                set { OsnovnaCijena = value; }
            }
            private double Marza;
            public double marza
            {
                get { return Marza; }
                set {
                    if (value <= 1 && value >= 0)
                        Marza = value;
                    else
                        Console.WriteLine("Unos treba biti iz intervala [0,1].");   
                }
            }
            public double IzracunajCijenu()
            {
                if (NaIzracunCijene != null)
                {
                    NaIzracunCijene(this, new EventArgs());
                }
                return this.OsnovnaCijena + this.OsnovnaCijena * this.Marza;
            }
        }
    }
}

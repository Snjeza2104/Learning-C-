using System;
using System.Collections.Generic;
using System.IO;

namespace Program_za_izdavanje_računa
{
    class Racun
    {
        //Zaglavlje
        private string NazivKupca;
        public string nazivkupca
        {
            get { return NazivKupca; }
            set { NazivKupca = value; }
        }
        private string Djelatnik;
        public string djelatnik
        {
            get { return Djelatnik; }
            set { Djelatnik = value; }
        }
        private DateTime Datum;
        public DateTime datum
        {
            get { return DateTime.Now; }
        }
        private string BrojRacuna;
        public string brojracuna
        {
            get { return BrojRacuna; }
            set { BrojRacuna = value; }
        }

        //stavke
        private List<Stavka> StavkeRacuna = new List<Stavka>();
        public List<Stavka> stavkeracuna
        {
            get { return StavkeRacuna; }
            set { StavkeRacuna = value; }
        }

        //Podnozje
        decimal zbroj = 0;
        //Zbrojiti ukupnu cijenu svake stavke
        

        //metoda SpremiUDatoteku
    }
    class Stavka
    {
        public string NazivProizvoda;
        public int Kolicina;
        public decimal Cijena;
        private decimal UkupnaCijena;
        public decimal ukupnacijena
        {
            get { UkupnaCijena= Kolicina * Cijena; return UkupnaCijena; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Racun racun = new Racun();
            FileStream fs = new FileStream("Racun.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Upišite naziv kupca:");
            sw.WriteLine("Naziv kupca: ");
            racun.nazivkupca = Console.ReadLine();
            sw.WriteLine(racun.nazivkupca);
            Console.WriteLine("Upišite ime i prezime djelatnika:");
            sw.WriteLine("Ime i prezime djelatnika: ");
            racun.djelatnik = Console.ReadLine();
            sw.WriteLine(racun.djelatnik);
            Console.WriteLine("Datum izdavanja računa: "+racun.datum);
            sw.WriteLine("Datum izdavanja računa: ");
            sw.WriteLine(racun.datum);
            Console.WriteLine("Upišite broj računa: ");
            sw.WriteLine("Broj računa: ");
            racun.brojracuna = Console.ReadLine();
            sw.WriteLine(racun.brojracuna);

            Stavka stavka = new Stavka();
            Console.WriteLine("Upišite naziv proizvoda: ");
            sw.WriteLine("Naziv proizvoda: ");
            stavka.NazivProizvoda = Console.ReadLine();
            sw.WriteLine(stavka.NazivProizvoda);
            Console.WriteLine("Unesite količinu proizvoda: ");
            sw.WriteLine("Količina");
            stavka.Kolicina = int.Parse(Console.ReadLine());
            sw.WriteLine(stavka.Kolicina);
            Console.WriteLine("Unesite cijenu proizvoda: ");
            sw.WriteLine("Cijena proizvoda: ");
            stavka.Cijena = decimal.Parse(Console.ReadLine());
            sw.WriteLine(stavka.Cijena);
            Console.WriteLine("Ukupna cijena stavke:");
            Console.WriteLine(stavka.ukupnacijena);
            sw.WriteLine("Ukupna cijena stavke: ");
            sw.WriteLine(stavka.ukupnacijena);

            racun.stavkeracuna.Add(stavka);

            Console.WriteLine("Želite li još stavki (d/n)?");
            string odgovor = Console.ReadLine();
            while (odgovor != "n")
            {
                Stavka stavka2 = new Stavka();
                Console.WriteLine("Upišite naziv proizvoda: ");
                sw.WriteLine("Naziv proizvoda: ");
                stavka2.NazivProizvoda = Console.ReadLine();
                sw.WriteLine(stavka2.NazivProizvoda);
                Console.WriteLine("Unesite količinu proizvoda: ");
                sw.WriteLine("Količina");
                stavka2.Kolicina = int.Parse(Console.ReadLine());
                sw.WriteLine(stavka2.Kolicina);
                Console.WriteLine("Unesite cijenu proizvoda: ");
                sw.WriteLine("Cijena proizvoda: ");
                stavka2.Cijena = decimal.Parse(Console.ReadLine());
                sw.WriteLine(stavka2.Cijena);
                Console.WriteLine("Ukupna cijena stavke:");
                Console.WriteLine(stavka2.ukupnacijena);
                sw.WriteLine("Ukupna cijena stavke: ");
                sw.WriteLine(stavka2.ukupnacijena);

                racun.stavkeracuna.Add(stavka2);
                Console.WriteLine("Želite li još stavki (d/n)?");
                odgovor = Console.ReadLine();
            }
            decimal zbroj = 0;
            foreach(Stavka namirnica in racun.stavkeracuna)
            {
                zbroj += namirnica.ukupnacijena;
            }

            Console.WriteLine("Ukupna cijena računa: " + zbroj +" kn");
            sw.WriteLine("Ukupna cijena računa: "+ zbroj +" kn");

            sw.Flush();
        }
    }
}

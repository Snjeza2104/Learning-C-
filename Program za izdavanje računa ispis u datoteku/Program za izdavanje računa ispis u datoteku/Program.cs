using System;
using System.Collections.Generic;
using System.IO;

namespace Program_za_izdavanje_računa_ispis_u_datoteku
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
        public void SpremiUDatoteku()
        {
            FileStream fs = new FileStream("Racun.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Naziv kupca: ");
            sw.WriteLine(this.nazivkupca);
            sw.WriteLine("Ime i prezime djelatnika: ");
            sw.WriteLine(this.djelatnik);
            sw.WriteLine("Datum izdavanja računa: ");
            sw.WriteLine(this.datum);
            sw.WriteLine("Broj računa: ");
            sw.WriteLine(this.brojracuna);
            sw.Flush();
            decimal zbroj = 0;
            foreach (Stavka stavka2 in this.stavkeracuna)
            {
                sw.WriteLine("Naziv proizvoda: ");
                sw.WriteLine(stavka2.NazivProizvoda);
                sw.WriteLine("Količina");
                sw.WriteLine(stavka2.Kolicina);
                sw.WriteLine("Cijena proizvoda: ");
                sw.WriteLine(stavka2.Cijena);
                sw.WriteLine("Ukupna cijena stavke: ");
                sw.WriteLine(stavka2.ukupnacijena);
                zbroj += stavka2.ukupnacijena;
            }
            sw.Flush();
            sw.WriteLine("Ukupna cijena računa: " + zbroj + " kn");
            sw.Flush();


        }
    }
    class Stavka
    {
        public string NazivProizvoda;
        public int Kolicina;
        public decimal Cijena;
        private decimal UkupnaCijena;
        public decimal ukupnacijena
        {
            get { UkupnaCijena = Kolicina * Cijena; return UkupnaCijena; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Racun racun = new Racun();
           
            Console.WriteLine("Upišite naziv kupca:");
            racun.nazivkupca = Console.ReadLine();
            Console.WriteLine("Upišite ime i prezime djelatnika:");
            racun.djelatnik = Console.ReadLine();
            Console.WriteLine("Datum izdavanja računa: " + racun.datum);
            Console.WriteLine("Upišite broj računa: ");
            racun.brojracuna = Console.ReadLine();
            

            Stavka stavka = new Stavka();
            Console.WriteLine("Upišite naziv proizvoda: ");
            stavka.NazivProizvoda = Console.ReadLine();
            Console.WriteLine("Unesite količinu proizvoda: ");
            stavka.Kolicina = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite cijenu proizvoda: ");
            stavka.Cijena = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ukupna cijena stavke:");
            Console.WriteLine(stavka.ukupnacijena);
            

            racun.stavkeracuna.Add(stavka);

            Console.WriteLine("Želite li još stavki (d/n)?");
            string odgovor = Console.ReadLine();
            while (odgovor != "n")
            {
                Stavka stavka2 = new Stavka();
                Console.WriteLine("Upišite naziv proizvoda: ");
                stavka2.NazivProizvoda = Console.ReadLine();
                Console.WriteLine("Unesite količinu proizvoda: ");
                stavka2.Kolicina = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite cijenu proizvoda: ");
                stavka2.Cijena = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ukupna cijena stavke:");
                Console.WriteLine(stavka2.ukupnacijena);
                racun.stavkeracuna.Add(stavka2);
                Console.WriteLine("Želite li još stavki (d/n)?");
                odgovor = Console.ReadLine();
            }
           

            Console.WriteLine("Ispisujem račun u datoteku Racun.txt");
            racun.SpremiUDatoteku();
            
        }
    }
}

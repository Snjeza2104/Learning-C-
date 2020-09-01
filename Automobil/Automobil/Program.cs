/*Napravite klasu Automobil:
  Polja:
    MarkaAutomobila(string)
    KS(double)
    OsnovnaCijena(double)
  Metode
    IznosPoreza(double)
        KS<50 -> 5%
        50<KS<150 -> 10%
        150>KS -> 15%
    Ukupna cijena=OsnovnaCijena+IznosPoreza

 U glavnom programu instancirajte objekt klase Automobil, tražite unos njegovih polja i ispišite na ekran
iznos poreza i ukupnu cijenu.*/
using System;

namespace Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();
            Console.Write("Unesite marku automobila: ");
            auto.marka = Console.ReadLine();
            Console.Write("Unesite broj konjskih snaga: ");
            auto.konjskesnage = double.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu: ");
            auto.cijena= double.Parse(Console.ReadLine());
            Console.Write("Iznos poreza je: ");
            Console.WriteLine(auto.IznosPoreza());
            Console.Write("Ukupna cijena je: ");
            Console.WriteLine(auto.UkupnaCijena());

        }
    }
    class Automobil
    {
        string MarkaAutomobila;
        public string marka
        {
            get { return MarkaAutomobila; }
            set { MarkaAutomobila = value; }
        }
        double KS;
        public double konjskesnage
        {
            get { return KS; }
            set { KS = value; }
        }
        double OsnovnaCijena;
        public double cijena
        {
            get { return OsnovnaCijena;}
            set { OsnovnaCijena = value; }
        }
        public double IznosPoreza()
        {
            if (this.KS < 50)
                return this.OsnovnaCijena * 0.05;
            else if (this.KS >= 50 && this.KS < 150)
                return this.OsnovnaCijena * 0.1;
            else
                return this.OsnovnaCijena * 0.15;
        }
        public double UkupnaCijena()
        {
            return this.OsnovnaCijena + IznosPoreza();
        }
    }
}

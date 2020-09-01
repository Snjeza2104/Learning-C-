using System;
using System.Collections;

namespace Proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            string naziv;
            double cijena;
            double marza;
            double porez;
            //Proizvod proizvod = new Proizvod();
            naziv = Console.ReadLine();
            Console.WriteLine("Unesi cijenu proizvoda: ");
            cijena = double.Parse(Console.ReadLine());
            //proizvod.Cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi maržu proizvoda: ");
            marza = double.Parse(Console.ReadLine());
            //proizvod.Marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi porez: ");
            porez = double.Parse(Console.ReadLine());
            //proizvod.Porez = double.Parse(Console.ReadLine());
            Proizvod proizvod = new Proizvod(naziv, cijena, marza, porez);
            Console.WriteLine(proizvod.MPC());
            proizvod.MPC();
            Console.WriteLine(Proizvod.br);
            naziv = Console.ReadLine();
            /*
            if (proizvod.setNaziv(naziv))
                Console.WriteLine("OK");
            else
                Console.WriteLine("False");
            */
            Console.WriteLine(proizvod.getNaziv());
            proizvod.setNaziv(naziv);
            Console.WriteLine(proizvod.getNaziv());
        }
    }
    class Proizvod
    {
         string Naziv;
         double Cijena;
         double Marza;
         double Porez;
        public static int br=0;
        
        public Proizvod()
        {
        }
        public Proizvod(string naziv, double cijena, double marza, double porez)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Marza = marza;
            this.Porez = porez;
        }
       public double MPC()
        {
            br++;
            return this.Cijena + this.Marza + this.Porez;
        }
        //Promjena private vrijednosti
        public bool setNaziv(string noviNaziv)
        {
            if (noviNaziv.Length < 10)
            {
                this.Naziv = noviNaziv;
                return true;
            }
            return false;
        }
        public string getNaziv()
        {
            return this.Naziv;
        }
    }
}

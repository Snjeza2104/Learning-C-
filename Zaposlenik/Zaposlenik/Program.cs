using System;
using System.Linq;

namespace Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik zaposlenik1 = new Zaposlenik("Matko", "Matković", "1234567890123");
            zaposlenik1.Bodovi = 12;
            Console.WriteLine(zaposlenik1.Bodovi);
            zaposlenik1.VrBoda = 31.42;
            zaposlenik1.print();
            Console.WriteLine(zaposlenik1.porez);
        }
    }
    class Zaposlenik
    {
        string Ime;
        string Prezime;
        string JMBG;
        int BrojBodova;
        public int Bodovi
        {
            get { return BrojBodova; }
            set { BrojBodova = value; }
        }
        public double VrBoda
        {
            get { return VrijednostBoda; }
            set { VrijednostBoda = value; }
        }
        double VrijednostBoda;
        double Porez;
        public double porez
        {
            get
            {
                double n = NetoIzracunPlace();
                if (n < 3000)
                {
                    Porez = n * 6 / 100;
                    return Porez;
                }
                if (n < 6000)
                {
                    Porez = n * 12 / 100;
                    return Porez;
                }
                Porez = 20 / 100*n;
                return Porez;
            }
        }
        public void print()
        {
            Console.WriteLine(this.BrojBodova);
        }
        double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }
        double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }
        public Zaposlenik()
        {

        }
        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }
        public Zaposlenik(string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;
        }
    }
}

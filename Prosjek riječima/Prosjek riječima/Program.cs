/*Izradite funkciju koja na temelju unesene prosječne ocjene riječima ispisuje poruku o uspjehu
 (npr. za prosječnu ocjenu 3.4 program ispisuje "Prosjek je dobar.")*/
using System;

namespace Prosjek_riječima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši prosječnu ocjenu: ");
            double ocjena = double.Parse(Console.ReadLine());
            Console.Write(Prosjek(ocjena));
        }
        static string Prosjek(double ocjena)
        {
            if (ocjena < 2)
            {
                return "Prosjek je nedovoljan.";
            }
            else if (ocjena < 2.5)
            {
                return "Prosjek je dovoljan.";
            }
            else if (ocjena < 3.5)
            {
                return "Prosjek je dobar.";
            }
            else if (ocjena < 4.5)
            {
                return "Prosjek je vrlo dobar.";
            }
            else if (ocjena <=5)
            {
                return "Prosjek je odličan.";
            }
            else
            {
                return "Ne postoji takav prosjek.";
            }
        }
    }
}

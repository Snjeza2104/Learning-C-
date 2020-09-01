/*Ukupna cijena=Ulazna cijena + Marža + Porez + PDV*/
using System;

namespace Ukupna_cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu: ");
            double cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Ukupna cijena je {0}.", UkupnaCijena(cijena));

        }
        static double UkupnaCijena (double cijena)
        {
            double marza = 0, porez = 0, PDV = 0;
            PDV = 0.22 * cijena;
            if (cijena < 100)
            {
                marza = 5.5;
                porez = 0.02 * cijena;
            }
            else if (cijena < 250)
            {
                marza = 9.5;
                porez = 0.03 * cijena;
            }
            else if (cijena < 500)
            {
                marza = 15;
                porez = 0.04 * cijena;
            }
            else if (cijena <= 1000)
            {
                marza = 25;
                porez = 0.05 * cijena;
            }
            else if (cijena > 1000)
            {
                marza = 50;
                porez = 0.1 * cijena;
            }
            return cijena + marza + porez + PDV;
        }
    }
}

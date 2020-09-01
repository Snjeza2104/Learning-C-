/*Napravite klasu sa static metodama:
    Zbroj(double broj1, double broj2)
    Kub(double broj)
    UdaljenostTocaka(double x1, double x2, double y1, double y2)
    CelzijFahrenheit(int stupnjevi)
Klasa se ne smije moći instancirati.*/
using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zbrajam: {0}", Racunam.Zbroj(2, 3));
            Console.WriteLine("Kubiram: {0}", Racunam.Kub(3));

        }
    }
    class Racunam
    {
        private Racunam()
        {

        }

        public static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }
        public static double Kub(double broj)
        {
            return Math.Pow(broj, 3);
        }
       public static double UdaljenostTocaka(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double CelzijFahrenheit(int stupnjevi)
        {
            return (double)9 / 5 * stupnjevi + 32;
        }
    }
}
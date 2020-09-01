using System;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši 2 broja (nakon svakog stisni Enter).");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Zbroji(a, b);
        }
        static void Zbroji(double x, double y)
        {
            Console.WriteLine("Zbroj {0}+{1}={2}", x, y, x + y);
        }
    }
}

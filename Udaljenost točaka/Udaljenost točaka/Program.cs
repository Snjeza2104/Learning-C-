/*Izradite funkciju koja računa udaljenost između 2 točke P1(x1,y1) i P2(x2,y2) d=V(x2-x1)2+(y2-y1)2*/
using System;

namespace Udaljenost_točaka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljenost točaka je {0}", Udaljenost(x1,y1,x2,y2));
         }
        static double Udaljenost(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }
    }
}

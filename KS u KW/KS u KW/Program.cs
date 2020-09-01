/*Izradite funkciju koja pretvara KS u KW (1KS=0.736 KW*/
using System;

namespace KS_u_KW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite KS: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} KS = {1} KW", a, Pretvori(a));
        }
        static double Pretvori(float a)
        {
            return  a * 0.736;
        }
    }
}

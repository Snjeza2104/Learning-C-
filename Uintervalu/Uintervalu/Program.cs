/*Napišite program koji traži unos broja i ispisuje je li broj u intervalu [100,200] ili ne.*/
using System;

namespace Uintervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj: ");
            float a = float.Parse(Console.ReadLine());
            if (a>=100 && a <= 200)
            {
                Console.WriteLine("Broj {0} je u intervalu [100,200]", a);
            }
            else
            {
                Console.WriteLine("Broj {0} nije u intervalu [100,200]", a);
            }
        }
    }
}

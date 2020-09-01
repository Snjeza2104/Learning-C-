/*Napišite program koji traži unos broja, te ispisuje je li broj pozitivan, negativan ili nula.*/

using System;

namespace Pozneg0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj:");
            float a = float.Parse(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine("Broj {0} je pozitivan.",a);
            }
            else if(a<0)
            {
                Console.WriteLine("Broj {0} je negativan.", a);
            }
            else
            {
                Console.WriteLine("Broj {0} je jednak 0.", a);
            }
        }
    }
}

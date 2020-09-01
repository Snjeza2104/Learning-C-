/*Napišite program koji traži unos godine i ispisuje je li ta godina prijestupna ili ne. Godina je prijestupna
 ako je djeljiva sa 4, nije djeljiva sa 100, osim ako je djeljiva sa 400.*/
using System;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite godinu: ");
            int a = int.Parse(Console.ReadLine());
            if (a%4==0 && (a%100!=0 || a % 400 == 0))
            {
                Console.WriteLine("Godina {0} je prijestupna.",a);
            }
            else
            {
                Console.WriteLine("Godina {0} nije prijestupna.",a);
            }
        }
    }
}

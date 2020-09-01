/*Napišite program koji traži unos broja i ispituje je li taj broj djeljiv s 5 ili s 3. Ako jest, ispisati
 "Broj je dobar", inače ispisati "Broj NIJE dobar!"*/
using System;

namespace Dobarbroj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite broj: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 5 == 0 || a % 3 == 0)
            {
                Console.WriteLine("Broj je dobar.");
            }
            else{
                Console.WriteLine("Broj NIJE dobar!");
            }
        }
    }
}

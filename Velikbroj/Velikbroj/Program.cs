/*Napišite program koji traži unos broja i zatim
 -ako broj ima više od 2 znamenke, ispisuje poruku "Broj je velik."
-inače ispisuje poruku "Broj NIJE velik."*/
using System;

namespace Velikbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj: ");
            int a = int.Parse(Console.ReadLine());
            if(a/100==0)
            {
                Console.WriteLine("Broj NIJE velik.");
            }
            else
            {
                Console.WriteLine("Broj je velik.");
            }
        }
    }
}

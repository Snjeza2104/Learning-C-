/*Napišite program koji traži unos broja i ispituje je li taj broj djeljiv sa 4 i nije manji od 100.
 Ako jest, ispisuje "Broj je dobar." Inače ispisuje "Broj NIJE dobar!". Programski kod treba osigurati od grešaka!*/
using System;

namespace Dobarbroj2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Upiši broj: ");
                int a = int.Parse(Console.ReadLine());
                if (a % 4 == 0 && !(a < 100))
                {
                    Console.WriteLine("Broj {0} je dobar.", a);
                }
                else
                {
                    Console.WriteLine("Broj {0} NIJE dobar!", a);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška u programu!");
                Console.WriteLine("Opis greške: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Pritisnite tipku za kraj...");
                Console.ReadKey();
            }
        }
    }
}

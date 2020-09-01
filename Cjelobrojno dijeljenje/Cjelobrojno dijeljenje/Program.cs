/*Napišite program koji traži unos broja te ispisuje je li taj broj paran ili neparan, te je li broj djeljiv
 s 3 ili koliki je ostatak pri dijeljenju s brojem 3.*/
using System;

namespace Cjelobrojno_dijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite broj:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if(a%2==0)
                {
                    Console.WriteLine("Broj {0} je paran.",a);
                }
                else
                {
                    Console.WriteLine("Broj {0} je neparan.", a);
                }
                if (a%3==0)
                {
                    Console.WriteLine("Broj {0} je djeljiv s 3.", a);
                }
                else
                {
                    Console.WriteLine("Broj {0} nije djeljiv s 3. ostatak pri dijeljenju je {1}.", a, a % 3);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Dogodila se greška: "+ex.Message);
            }
        }
        
    }
}

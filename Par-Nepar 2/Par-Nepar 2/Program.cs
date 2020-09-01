/*Napišite program koji traži unos 10 prirodnih brojeva i parne i neparne sprema odvojeno, u
 dva objekta klase List<int> i zatim ispisuje te dvije kolekcije brojeva.*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Par_Nepar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parni = new List<int>();
            List<int> neparni = new List<int>();
            int a = 0;
            Console.WriteLine("Upiši 10 prirodnih brojeva i nakon svakog stisni Enter.");
            for (int i = 0; i < 10; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    parni.Add(a);
                }
                else if (a % 2 == 1)
                {
                    neparni.Add(a);
                }
                else
                {
                    Console.WriteLine("Došlo je do greške s unosom.");
                }
            }
            Console.WriteLine("Ispisujem parne brojeve: ");
            foreach(int broj in parni)
            {
                Console.WriteLine("{0}", broj);
            }
            Console.WriteLine("Ispisujem neparne brojeve: ");
            foreach (int broj2 in neparni)
            {
                Console.WriteLine("{0}", broj2);
            }
        }
    }
}

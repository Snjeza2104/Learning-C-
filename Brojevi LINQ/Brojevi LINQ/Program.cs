/*Napišite program koji traži unos brojeva sve dok korisnik ne unese broj 0.
 Na konzolnom prozoru neka ispiše broj parnih i broj neparnih brojeva, koristeći LINQ upite.*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brojevi_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Učitavam cijele brojeve dok se ne unese 0");
            List<int> brojevi = new List<int>();
            int broj = int.Parse(Console.ReadLine());
            while (broj != 0)
            {
                brojevi.Add(broj);
                broj = int.Parse(Console.ReadLine());
            }
            List<int> parni = (from broj2 in brojevi where broj2 % 2 == 0 select broj2).ToList();
            Console.WriteLine("Parni brojevi su:");
            foreach(int br in parni)
            {
                Console.WriteLine(br);
            }
            Console.WriteLine("Parnih brojeva ima "+ parni.Count +".");
            List<int> neparni = (from broj2 in brojevi where broj2 % 2 == 1 select broj2).ToList();
            Console.WriteLine("Neparni brojevi su:");
            foreach (int br2 in neparni)
            {
                Console.WriteLine(br2);
            }
            Console.WriteLine("Neparnih brojeva ima " + neparni.Count + ".");
        }
    }
}

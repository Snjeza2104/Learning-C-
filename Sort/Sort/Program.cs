/*Napišite program koji traži unos prirodnih brojeva dok se ne unese 0 i zatim ispisuje unesene brojeve
 poredane po veličini pomoću petlje foreach.*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši prirodne brojeve odvojene znakom Enter, stanem dok uneseš 0:");
            int broj = broj = int.Parse(Console.ReadLine()); ;
            List<int> brojevi = new List<int>();
            while (broj != 0)
            {
                brojevi.Add(broj);
                broj = int.Parse(Console.ReadLine());
            }
            brojevi.Sort();
            Console.WriteLine("Ispisujem poredane brojeve");
            foreach(int broj2 in brojevi)
            {
                Console.WriteLine("{0}", broj2);
            }
        }
    }
}

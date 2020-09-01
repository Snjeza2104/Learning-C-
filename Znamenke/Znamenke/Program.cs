/*Napišite program koji traži unos prirodnog broja, a zatim znamenke upisanog broja ispisuje naopako.*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite prirodni broj: ");
            int a = int.Parse(Console.ReadLine());
            List<int> znamenke = new List<int>();
            while (a != 0)
            {
                znamenke.Add(a % 10);
                a /= 10;
            }
            foreach(int z in znamenke)
            {
                Console.WriteLine("{0}", z);
            }
        }
    }
}

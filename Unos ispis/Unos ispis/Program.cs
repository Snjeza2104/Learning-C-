/*Napišite program koji traži unos 10 prirodnih brojeva i zatim ih ispisuje.*/
using System;
using System.Collections;

namespace Unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polje = new int[10];
            Console.WriteLine("Upiši 10 prirodnih brojeva: ");
            for(int i=0; i < polje.Length; i++)
            {
                polje[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ispisujem upisane brojeve.");
            for(int j=0; j < polje.Length; j++)
            {
                Console.WriteLine("{0}", polje[j]);
            }
        }
    }
}

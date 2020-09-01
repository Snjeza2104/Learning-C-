/*Napišite program koji traži unos 10 elemenata i sprema ih u objekt tipa ArrayList, a zatim ih ispisuje
 naopako.*/
using System;
using System.Collections;

namespace Naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("Upiši 10 elemenata i nakon svakog stisni Enter.");
            for(int i=0; i < 10; i++)
            {
                lista.Add(Console.ReadLine());
            }
            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine("{0}. element je: {1}.", j, lista[j]);
            }
        }
    }
}

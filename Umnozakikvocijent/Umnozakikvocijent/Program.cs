/*Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu
 njihov zbroj te razliku.*/
using System;

namespace Umnozakikvocijent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši prvi broj:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Upiši drugi broj:");
            int b = int.Parse(Console.ReadLine());
            float c = (float)a/(float)b;
            Console.WriteLine("Umnožak je {0}, a kvocijent {1}.", a * b, c);
        }
    }
}

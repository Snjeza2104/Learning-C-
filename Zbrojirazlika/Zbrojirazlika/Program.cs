/*Napišite program koji traži unos 2 cijela broja i prikazuje na
 ekranu njihov zbroj te razliku.*/

using System;

namespace Zbrojirazlika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši prvi broj:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Upiši drugi broj:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj je {0}, a razlika {1}.", a+b, a-b);
        }
    }
}


			
		

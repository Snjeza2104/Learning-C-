/*Napišite program koji traži unos rečenice i zatim broji koliko ima riječi u toj rečenici.*/
using System;

namespace Brojanje_riječi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši rečenicu i prebrojat ću njene riječi: ");
            string recenica = Console.ReadLine();
            string[] rijeci = recenica.Split(' ');
            Console.WriteLine(rijeci.Length);
        }
    }
}

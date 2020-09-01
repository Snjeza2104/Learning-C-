/*Napišite program koji za uneseni broj X ispisuje X! (faktorijel)*/
using System;
using System.Security.Cryptography.X509Certificates;

namespace Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktorijel = 1;
            Console.WriteLine("Unesite prirodan broj i izračunat ću faktorijel: ");
            int X = int.Parse(Console.ReadLine());
            for(int i=1; i<=X; i++)
            {
                faktorijel *= i;
            }
            Console.WriteLine("{0}!={1}",X, faktorijel);
        }
    }
}

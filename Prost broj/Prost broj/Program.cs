/*Napišite program koji u funkciji ispituje je li uneseni prirodni broj prost ili složen 
 * (broj je prost ako je djeljiv samo s 1 i sa samim sobom.*/
using System;

namespace Prost_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj i provjerit ću je li prost ili složen: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(Provjeri(broj));
        }
        static string Provjeri(int a)
        {
            int djelitelji = 0;
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    djelitelji++;
                }
            }
            if (djelitelji == 0)
            {
                return "Prost.";
            }
            else
            {
                return "Složen.";
            }
        }
    }
}

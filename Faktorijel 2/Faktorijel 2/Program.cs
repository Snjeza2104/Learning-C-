/*Napišite program koji za uneseni prirodni broj računa faktorijel.
 n!=1*2*...*(n-1)*n
Zadatak riješite pomoću funkcije.*/
using System;

namespace Faktorijel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj i izračunat ću ti faktorijel: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}!={1}", n, Faktorijel(n));
        }
        static int Faktorijel(int n)
        {
            int faktorijel = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorijel *= i;
            }
            return faktorijel;
        }
    }
}

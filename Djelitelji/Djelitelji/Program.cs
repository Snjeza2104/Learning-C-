/*Napišite program koji za uneseni prirodni broj ispisuje sve njegove djelitelje.*/
using System;

namespace Djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

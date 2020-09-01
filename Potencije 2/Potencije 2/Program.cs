/*Napišite program koji ispisuje od 1. do 10. potencije broja 2.*/
using System;

namespace Potencije_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for(int i = 1; i <= 10; i++)
            {
                a *= 2;
                Console.WriteLine("{0}. potencija broja 2 je: {1}.", i, a);
            }
        }
    }
}

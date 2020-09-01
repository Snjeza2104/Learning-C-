/*Napišite program koji traži unos 10 prirodnih brojeva, a zatim ispisuje najmanji i najveći.*/
using System;

namespace Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 0, min=0, max=0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Upiši {0}. prirodni broj: ", i);
                broj = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    min = broj;
                    max = broj;
                }
                if (broj<min)
                {
                    min = broj;
                }
                if (broj > max)
                {
                    max = broj;
                }
            }
            Console.WriteLine("Najmanji broj je {0}, a najveći {1}",min,max);
        }
    }
}

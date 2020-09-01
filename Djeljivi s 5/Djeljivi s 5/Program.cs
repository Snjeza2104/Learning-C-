/*Napišite program koji ispisuje sve brojwvw od 1 do 100 djeljive s 5.*/
using System;

namespace Djeljivi_s_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}

/*Napišite program koji ispisuje sve potencije broja 2 manje od 1000.*/
using System;

namespace Potencije_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a < 1000)
            {
                Console.WriteLine("{0}", a);
                a *= 2;
            }
        }
    }
}

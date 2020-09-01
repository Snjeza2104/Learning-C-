/*Napišite program koji ispisuje sve neparne brojeve veće od 1, a manje ili jednake 20.*/
using System;

namespace Neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

/*Napišite program koji ispisuje sve neparne brojeve iz intervala [1,10].*/
using System;

namespace Neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

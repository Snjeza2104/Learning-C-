/*Napišite program koji ispisuje prirodne brojeve iz intervala [1,10] unatrag.*/
using System;

namespace Ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=10; i >= 1; i--)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}

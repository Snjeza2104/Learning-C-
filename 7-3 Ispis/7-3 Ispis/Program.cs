/*Napišite program koji ispisuje sve brojeve iz intervala [1,100] koji su djeljivi sa 7, ali nisu djeljivi s 3.*/
using System;

namespace _7_3_Ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%7==0 && !(i % 3 == 0))
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

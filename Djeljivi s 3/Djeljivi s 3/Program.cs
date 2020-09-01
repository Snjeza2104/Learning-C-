/*Napišite program koji ispisuje sve prirodne brojeve iz intervala [1,100] koji su djeljivi s brojem 3.*/
using System;

namespace Djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}

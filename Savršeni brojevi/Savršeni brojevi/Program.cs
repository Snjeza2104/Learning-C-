/*Napišite program koji ispisuje sve savršene brojeve iz intervala [1,1000].*/
using System;

namespace Savršeni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;
            for(int i = 1; i <= 1000; i++)
            {
                for(int j=1;j<i; j++)
                {
                    if (i % j == 0)
                    {
                        zbroj += j;
                    }
                }
                if (zbroj == i)
                {
                    Console.WriteLine("{0}",i);
                }
                zbroj = 0;
            }
        }
    }
}

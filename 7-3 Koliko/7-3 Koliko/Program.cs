/*Napišite program koji ispisuje koliko ima brojeva djeljivih sa 7 i nedjeljivih s 3 u intervalu [1,1000].*/
using System;

namespace _7_3_Koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojac = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i%7==0 && i%3!=0)
                {
                    brojac++;
                }
            }
            Console.WriteLine("U intervalu [1,1000] ima {0} brojeva djeljivih sa 7 i nedjeljivih s 3", brojac);
        }
    }
}

/*Napišite program koji ispisuje sve prijestupne godine od 1900. do 2007.
 (Godina je prijestupna ako je djeljiva sa 4, nije djeljiva sa 100, osim ako je djeljiva sa 400.)*/
using System;

namespace Prijestupne_godine
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1900;i<=2007; i++)
            {
                if(i%4==0 && (i%100!=0 || i%400==0))
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

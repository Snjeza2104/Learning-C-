/*Napišite program koji traži unos broja i zatim ispisuje je li taj broj jednoznamenkast, dvoznamenkast,
 troznamenkast ili višeznamenkast. Program treba raditi i s negativnim brojevima!*/
using System;

namespace Xznamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj: ");
            int a = int.Parse(Console.ReadLine());
            if(a%10!=0 && a / 10 == 0)
            {
                Console.WriteLine("Broj je jednoznamenkast.");
            }
            else if(a%100!=0 && a/100 == 0)
            {
                Console.WriteLine("Broj je dvoznamenkast.");
            }
            else if(a%1000!=0 && a / 1000 == 0)
            {
                Console.WriteLine("Broj je troznamenkast.");
            }
            else
            {
                Console.WriteLine("Broj je višeznamenkast.");
            }
        }
    }
}

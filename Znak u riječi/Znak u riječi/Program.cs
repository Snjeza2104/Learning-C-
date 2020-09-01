/*Napišite program koji traži unos jedne riječi i unos jednog znaka i zatim 
 ispisuje koliko se puta taj znak pojavljuje u toj riječi.*/
using System;

namespace Znak_u_riječi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite riječ: ");
            string rijec = Console.ReadLine();
            Console.WriteLine("Upišite znak: ");
            char znak = char.Parse(Console.ReadLine());
            Console.WriteLine(znakurijeci(rijec, znak));
            int znakurijeci(string rijec, char znak)
            {
                int broj = 0;
                for (int i = 0; i < rijec.Length; i++)
                {
                    if (rijec[i] == znak) broj++;
                }
                return broj;
            }
        }
       
    }
}

/*Napišite program koji traži unos jedne linije teksta i zatim ispisuje je li taj tekst
 palindrom(palindrom je riječ koja je ista čitamo li je s lijeve ili desne strane).*/
using System;
using System.Linq;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite riječ i provjerit ću je li palindrom: ");
            string rijec = Console.ReadLine();
            string rijec2 = rijec;
            int brojac = 0;
            for(int i=0; i < rijec.Length; i++)
            {
                    if (rijec[i] == rijec[rijec.Length-i-1]) brojac++;
                
            }
            if (brojac == rijec.Length)
            {
                Console.WriteLine("Palindrom.");
            }
            else
            {
                Console.WriteLine("Nije palindrom.");
            }
        }
    }
}

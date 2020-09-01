
/*Napišite program koji traži unos jedne rečenice i unos 
 * jedne riječi i zatim ispisuje koliko se puta ta riječ pojavljuje u toj rečenici.*/
using System;

namespace Riječ_u_rečenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši rečenicu: ");
            string recenica = Console.ReadLine();
            Console.Write("Upiši riječ: ");
            string rijec = Console.ReadLine();
            string[] rijeci = recenica.Split(' ');
            int brojac = 0;
            for(int i=0; i < rijeci.Length; i++)
            {
                if (rijeci[i].ToUpper() == rijec.ToUpper()) brojac++;
            }
            Console.Write("Riječ "+rijec+" se u rečenici "+recenica+" pojavljuje {0} puta.", brojac);
        }
    }
}

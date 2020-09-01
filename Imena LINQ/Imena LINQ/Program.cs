/*Napišite program koji traži unos imena sve dok se ne unese riječ "kraj". Na konzolni prozor neka ispiše
 sva imena koja u sebi sadrže slovo "a". Program mora podržavati velika i mala slova*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imena_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisuj imena i stisni Enter nakon svakog. Za kraj upiši riječ \"kraj\"");
            List<string> imena = new List<string>();
            string unos = Console.ReadLine();
            while (unos.ToLower() != "kraj")
            {
                imena.Add(unos);
                unos = Console.ReadLine();
            }
           
            //Ispis svih koji imaju slovo a
            Console.WriteLine("Sva imena koja sadrže slovo A:");
            List<string> trazeneOsobe = (from ime in imena 
                                         where ime.Contains("a") || ime.Contains("A") select ime).ToList();
            foreach (string ime in trazeneOsobe)
            {
                Console.WriteLine(ime);
            }
        }
    }
}

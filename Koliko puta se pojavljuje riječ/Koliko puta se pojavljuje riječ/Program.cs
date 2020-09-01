/*Napišite program koji traži unos rečenice i zatim broji koliko se puta
 pojavljuje koja riječ iz te rečenice. Program treba ignorirati velika i 
mala slova.*/
using System;
using System.Collections;

namespace Koliko_puta_se_pojavljuje_riječ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši rečenicu: ");
            string recenica = Console.ReadLine();
            string[] rijeci = recenica.Split(' ');
            ArrayList pojavljivanje = new ArrayList();
            int pojavi = 0;
            for(int i=0; i < rijeci.Length; i++)
            {
                pojavi = 0;
                for(int j = 0; j < rijeci.Length; j++)
                {
                    if (rijeci[i].ToUpper() == rijeci[j].ToUpper())
                    {
                        pojavi++;
                    }
                }
                pojavljivanje.Add(pojavi);
                Console.WriteLine(pojavi);
            }
        }
    }
}

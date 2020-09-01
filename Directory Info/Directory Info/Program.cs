/*Napišite program koji će za unesenu putanju ispisati sve direktorije koje ta putanja sadrži
 te koliko svaki sadrži datoteka, a koliko poddirektorija.*/
using System;
using System.IO;

namespace Directory_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite putanju: ");
            string putanja = Console.ReadLine();
            string[] direktoriji = Directory.GetDirectories(putanja);
            foreach(string direktorij in direktoriji)
            {
                Console.WriteLine(direktorij);
            }
            Console.WriteLine(direktoriji.Length + " ima poddirektorija.");
            string[] datoteke = Directory.GetFiles(putanja);
            Console.WriteLine(datoteke.Length + " ima datoteka.");
           
        }
    }
}

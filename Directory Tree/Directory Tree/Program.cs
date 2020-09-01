/*Napišite program koji će za unesenu putanju ispisati sve poddirektorije na toj putanji.*/
using System;
using System.IO;

namespace Directory_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite putanju: ");
            string putanja = Console.ReadLine();
            if (Directory.Exists(putanja))
            {
                //Radi dalje
                string[] direktoriji = Directory.GetDirectories(putanja);
                foreach(string direktorij in direktoriji)
                {
                    Console.WriteLine(direktorij);
                }
            }
            else
            {
                //Nema takve putanje
                Console.WriteLine("Ne postoji takva putanja.");
            }

        }
    }
}

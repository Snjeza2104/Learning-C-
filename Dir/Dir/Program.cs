/*Napravite program koji će za unesenu putanju ispisati sve datoteke i sve direktorije u toj mapi.*/
using System;
using System.IO;

namespace Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite putanju: ");
            string putanja = Console.ReadLine();

            //Datoteke s putanje
            Console.WriteLine("Ispisujem sve datoteke s putanje: "+putanja);
            string[] sFiles = Directory.GetFiles(putanja);
            foreach (string datoteka in sFiles)
            {
                Console.WriteLine(datoteka);
            }

            //Direktoriji s putanje
            Console.WriteLine("Ispisujem sve direktorije s putanje: " + putanja);
            string[] sDirs = Directory.GetDirectories(putanja);
            foreach (string direktorij in sDirs)
            {
                Console.WriteLine(direktorij);
            }

            Console.ReadKey();
        }
    }
}

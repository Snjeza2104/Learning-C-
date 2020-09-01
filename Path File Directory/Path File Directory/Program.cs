/*Program koji demonstrira upotrebu klasa Path, File, Directory*/
using System;
using System.IO;

namespace Path_File_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava naš program: ");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.Write("Postoji li file Proba.txt u izvršnoj mapi: ");
            //Path klasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");
            //File klasa
            Console.WriteLine(File.Exists(mojaPutanja));

            //Directory klasa
            if (!(Directory.Exists("Proba")))
            {
                //Ako ne postoji folder Proba, kreiram ga
                Directory.CreateDirectory("Proba");
            }

            //Ispisujem sve foldere na C-u
            Console.WriteLine("Direktoriji na C:");
            string[] sDirs = Directory.GetDirectories(@"C:\");
            foreach(string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            //Ispisujem sve fileove na C-u
            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach(string sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
            Console.ReadKey();
        }
    }
}

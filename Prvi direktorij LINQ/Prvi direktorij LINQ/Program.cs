/*Napišite program koji traži unos putanje i ispisuje naziv prvog pronađenog direktorija na putanji
 po abecednom redu, silazno. Program ne smije prijaviti grešku ako nije pronađen niti jedan direktorij.*/
using System;
using System.IO;
using System.Linq;

namespace Prvi_direktorij_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite putanju: ");
            string putanja = Console.ReadLine();
            string[] direktoriji = Directory.GetDirectories(putanja);
            string prvaputanja = (from direktorij in direktoriji orderby direktorij 
                                  select direktorij).FirstOrDefault();
            Console.WriteLine(prvaputanja);
        }
    }
}

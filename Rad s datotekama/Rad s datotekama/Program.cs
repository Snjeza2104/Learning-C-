using System;
using System.IO;

namespace Rad_s_datotekama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite tekst: ");
            string upisano = Console.ReadLine();

            //Zapisivanje u datoteku
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(upisano);
            sw.Flush();
            sw.Close();
            fs1.Close();

            //Čitanje iz datoteke
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2);
            string procitano = sr.ReadToEnd();
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);
            Console.ReadKey();
        }
    }
}

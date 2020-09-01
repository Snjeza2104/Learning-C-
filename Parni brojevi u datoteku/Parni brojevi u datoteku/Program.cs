/*Napišite program koji sve parne brojeve iz intervala [1,100] zapisuje u datoteku Parni.txt i zatvara ju.
 Nakon toga otvara tu istu datoteku i njezin sadržaj ispisuje na ekran*/
using System;
using System.IO;

namespace Parni_brojevi_u_datoteku
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("Parni.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            for(int i=1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    //Upisati parne brojeve u datoteku
                    sw.WriteLine(i);
                }
            }
            sw.Flush();
            sw.Close();
            fs1.Close();

            //Čitanje iz datoteke
            FileStream fs2 = new FileStream("Parni.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2);
            string procitano = sr.ReadToEnd();
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);
            Console.ReadKey();
        }
    }
}

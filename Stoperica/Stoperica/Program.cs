/*Napišite program Štoperica koji će na pritisak neke tipke početi mjeriti vrijeme. Kad se sljedeći put
 pritisne neka tipka, program će ispisati koliko je vremena proteklo.*/
using System;

namespace Stoperica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Na pririsak tipke počinjem štopati vrijeme.");
            Console.ReadKey();
            //učitati datum Now
            DateTime pocni = DateTime.Now;

            Console.WriteLine("Na pritisak tipke prestajem štopati vrijeme.");
            Console.ReadKey();
            //učitava datum Now
            DateTime stani = DateTime.Now;
            TimeSpan ts = stani - pocni; //interval
            Console.WriteLine("Prošlo je ukupno vremena: "+ts);
            Console.WriteLine("{0}:{1}:{2} {3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}

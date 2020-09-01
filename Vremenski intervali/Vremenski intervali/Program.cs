using System;

namespace Vremenski_intervali
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2009,1,1,10,0,0);
            DateTime datum2 = new DateTime(2010,1,1,12,0,0);

            TimeSpan interval = datum2 - datum1;

            Console.WriteLine(interval);
            Console.WriteLine(interval.Days);
            Console.WriteLine(interval.Hours);
            Console.WriteLine(interval.TotalHours);
        }
    }
}

using System;

namespace Primjer_s_datumima
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2015, 1, 1);
            DateTime datum2 = new DateTime(2016, 8, 1);
            if (datum1 < datum2)
            {
                Console.WriteLine("1.1.2015. je manji od 1.8.2016.");
            }
            else
            {
                Console.WriteLine("1.1.2015. je veći od 1.8.2016.");
            }
        }
    }
}

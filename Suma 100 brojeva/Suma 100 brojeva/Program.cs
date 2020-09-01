using System;

namespace Suma_100_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;
            for(int i = 1; i <= 100; i++)
            {
                zbroj += i;
            }
            Console.WriteLine("Zbroj prvih 100 prirodnih brojeva je {0}.", zbroj);
        }
    }
}

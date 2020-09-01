using System;

namespace Suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 0, zbroj=0;
           for(int i=1; i <= 5; i++)
            {
                Console.Write("Unesi {0}. prirodan broj: ", i);
                broj = int.Parse(Console.ReadLine());
                zbroj += broj;
            }
            Console.WriteLine("Zbroj je {0}, a prosjek {1}", zbroj, (float)zbroj / 5);
        }
    }
}

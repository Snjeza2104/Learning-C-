/*Program koji traži unos prirodnih brojeva dok se ne unese 0, a onda ispisuje njihovu sumu.*/
using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0, a=0;
            Console.WriteLine("Upiši broj: ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Zbroj je {0}", zbroj);
            }
            else {
                while (a != 0)
                { 
                        zbroj += a;
                        a = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Zbroj je {0}", zbroj);


        }
    }
}

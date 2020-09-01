/*Napišite program koji ispisuje je li uneseni broj savršen ili ne. Savršen broj je broj koji je jednak
 zbroju svojih djelitelja (bez njega samoga)*/
using System;

namespace Savrseni_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši broj: ");
            int a = int.Parse(Console.ReadLine());
            int zbroj = 0;
            for(int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    zbroj += i;
                }
            }
            if (zbroj == a)
            {
                Console.WriteLine("Broj {0} je savršen.",a);
            }
            else
            {
                Console.WriteLine("Broj {0} nije savršen.",a);
            }
        }
    }
}

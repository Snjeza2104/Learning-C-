/*Program koji traži unos prirodnih brojeva dok se ne unese 0, a zatim ispisuje koliko je bilo uneseno
 parnih, a koliko neparnih (0 se na kraju ne računa ni kao paran ni kao neparan).*/
using System;

namespace Par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            int parnih = 0, neparnih = 0;
            Console.WriteLine("Upiši priridan broj, učitavam dok ne napišeš 0. ");
            int unos = int.Parse(Console.ReadLine());
            while (unos != 0)
            {
                if (unos % 2 == 0)
                {
                    parnih++;
                }
                else
                {
                    neparnih++;
                }
                unos = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Parnih brojeva ima {0}, a neparnih {1}.", parnih, neparnih);
        }
    }
}

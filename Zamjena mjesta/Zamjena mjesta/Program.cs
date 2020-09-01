/*Napišite program koji traži unos 10 brojeva (elemenata niza) i zatim ih ispisuje, ali najvećem i najmanjem
 treba zamijeniti mjesta.*/
using System;

namespace Zamjena_mjesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši 10 brojeva i nakon svakog stisni Enter");
            float[] niz = new float[10];
            float najmanji, najveci;
            int poznajm=-1, poznajv=-1;
            niz[0] = int.Parse(Console.ReadLine());
            najmanji = niz[0];
            najveci = niz[0];
            poznajm = 0;
            poznajv = 0;
            for (int i = 1; i < niz.Length; i++)
            {
                niz[i] = int.Parse(Console.ReadLine());
                if (niz[i] > najveci)
                {
                    najveci = niz[i];
                    poznajv = i;
                }
                if (niz[i] < najmanji)
                {
                    najmanji = niz[i];
                    poznajm = i;
                }
            }
            float t = niz[poznajm];
            niz[poznajm] = niz[poznajv];
            niz[poznajv] = t;
            Console.WriteLine("Mijenjam mjesto najmanjem i najvećem broju: ");
            for(int j = 0; j < niz.Length; j++)
            {
                Console.WriteLine("{0}", niz[j]);
            }
        }
    }
}

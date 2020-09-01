/*Napišite program koji traži unos 5 brojeva, a zatim ih ispisuje, s time da najveći ispisuje
 crvenom bojom.*/
using System;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva, nakon svakog stisni Enter. ");
            float[] niz = new float[5];
            float max = 0;
            for(int i=0; i<niz.Length; i++)
            {
                niz[i] = float.Parse(Console.ReadLine());
                if (niz[i] > max)
                {
                    max = niz[i];
                }
            }
            for(int j = 0; j < niz.Length; j++)
            {
                if (niz[j]== max)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(niz[j]);
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine(niz[j]);
                    }
               
            }
        }
    }
}

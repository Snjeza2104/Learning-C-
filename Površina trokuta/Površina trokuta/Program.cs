/*Napišite program koji za unesenu duljinu osnovice i visine na tu osnovicu računa površinu trokuta
 P=a*v/2    */
using System;

namespace Površina_trokuta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši duljinu osnovice trokuta: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Upiši duljinu visine na tu osnovicu trokuta: ");
            float va = float.Parse(Console.ReadLine());
            Console.WriteLine("Površina trokuta je {0}.", Povrsina(a, va));
        }
        static double Povrsina(float a, float v)
        {
            return a * v / 2;
        }
    }
}

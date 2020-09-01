using System;
using System.Collections.Generic;

namespace Hipotenuza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši katetu a pravokutnog trokuta: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Upiši katetu b pravokutnog trokuta: ");
            float b = float.Parse(Console.ReadLine());
            Hipotenuza(a, b);
        }
        static void Hipotenuza(float a, float b)
        {
            float c = (float) Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hipotenuza c je jednaka {0}.", c);
        }
    }
}

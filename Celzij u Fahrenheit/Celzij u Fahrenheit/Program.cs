/*Izradite funkciju koja preračunava stupnjeve Celzijeve ljestvice u Fahrenheitove
 Tf=9/5*Tc+32*/
using System;

namespace Celzij_u_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi temperaturu u stupnjevima Celzijevim: ");
            float Tc = float.Parse(Console.ReadLine());
            Console.WriteLine("{0}°C={1} F", Tc, Pretvori(Tc));
        }
        static double Pretvori(float Tc)
        {
            return ((float)9 / 5) * Tc + 32;
        }
    }
}

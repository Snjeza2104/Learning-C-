/*Napišite program koji za uneseni radijus ispisuje opseg i površinu kruga
 O=2*r*Pi      P=r*r*Pi*/
using System;

namespace Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši radijus kruga i izračunat ću ti njegov opseg i površinu: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Opseg kruga radijusa {0} je {1}, a površina {2}.", r, Opseg(r), Povrsina(r));
        }
        static double Opseg(float r)
        {
            return 2 * r * Math.PI;
        }
        static double Povrsina(float r)
        {
            return r * r * Math.PI;
        }
    }
}

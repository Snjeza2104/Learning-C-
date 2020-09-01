/*Napišite program - kalkulator s osnovnim računskim operacijama. Program traži unos 2 cijela broja,
 a zatim unos računske operacije. Nakon toga ispisuje rezultat i omogućuje korisniku ponovno računanje
ili prekid programa. Program treba ispisivati sve poruke za korisnika.*/
using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "DA";
            int a = 0, b = 0;
            char c;
            while (s == "DA")
            {
            Console.Write("Upiši prvi cijeli broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Upiši drugi cijeli broj: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Upiši znak za računsku operaciju: ");
            c = char.Parse(Console.ReadLine()) ;
            Console.WriteLine("{0}{1}{2}",a,c,b);
            switch (c)
            {
                case '+':
                    Console.WriteLine("Zbroj: {0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("Razlika: {0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("Umnožak: {0}", a * b);
                    break;
                case '/':
                    Console.WriteLine("Kvocijent: {0}", a / b);
                    break;
                default:
                    Console.WriteLine("Nepoznata računska operacija.");
                    break;
            }
            Console.WriteLine("Želite li ponovno računati?");
            s = Console.ReadLine();
           
            }
        }
    }
}

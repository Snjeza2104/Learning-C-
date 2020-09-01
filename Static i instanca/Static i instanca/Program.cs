/*Napravite klasu koja ima:
    static funkciju koja vraća je li broj prost ili složen
    metodu instance koja ispituje je li broj savršen (jednak zbroju svih svojih djelitelja osim njega samoga)*/
using System;

namespace Static_i_instanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj i ispitat ću je li prost ili savršen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Prost: "+Funkcije.Prost(n));
            Funkcije f = new Funkcije();
            Console.WriteLine("Savršen: "+f.Savrsen(n));
        }
    }
    class Funkcije{
        public static bool Prost(int n)
        {
            for(int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public bool Savrsen(int n)
        {
            int zbroj = 0;
            for(int i = 1; i <= n - 1; i++)
            {
                if (n % i==0)
                    zbroj += i;
            }
            if (zbroj == n) return true;
            else return false;
        }
    }
}

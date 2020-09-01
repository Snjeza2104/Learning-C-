/*Napišite program koji preko funkcije traži unos brojeva sve dok se ne unese 0. Napišite funkciju
 koja će iz unesenih brojeva izvući neparne brojeve, te funciju koja će iz unesenih brojeva izvući
parne brojeve. Izradite funkciju koja će ispisati posebno neparne, a posebno parne brojeve.*/
using System;
using System.Collections.Generic;

namespace Parni_i_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Učitavam brojeve dok ne upišeš 0: ");
            List<double> listabrojeva = new List<double>();
            List<double> listaparnih = new List<double>();
            List<double> listaneparnih = new List<double>();
            double a = 1;
           listabrojeva = Unos(a, listabrojeva);
            listaparnih = Parni(listabrojeva, listaparnih);
            listaneparnih = Neparni(listabrojeva, listaneparnih);
            Console.WriteLine("Parni brojevi su:");
            Ispis(listaparnih);
            Console.WriteLine("Neparni brojevi su:");
            Ispis(listaneparnih);
        }
        static List<double> Unos(double a, List<double> listabrojeva)
        {
            a=double.Parse(Console.ReadLine());
            while (a != 0)
            {
                listabrojeva.Add(a);
                a = double.Parse(Console.ReadLine());
            }
            return listabrojeva;
        }
        static List<double> Parni(List<double> listabrojeva, List<double> listaparnih)
        {
            foreach(double a in listabrojeva)
            if (a % 2 == 0)
            {
                    listaparnih.Add(a);
            }
            return listaparnih;
        }
        static List<double> Neparni(List<double> listabrojeva, List<double> listaneparnih)
        {
            foreach (double a in listabrojeva)
                if (a % 2 == 1)
                {
                    listaneparnih.Add(a);
                }
            return listaneparnih;
        }
        static void Ispis(List<double> brojevi)
        {
            foreach(double br in brojevi)
            {
                Console.WriteLine("{0}", br);
            }
        }
    }
}

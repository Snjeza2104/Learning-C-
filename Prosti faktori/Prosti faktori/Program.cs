/*Napišite program koji traži unos prirodnog broja, a zatim ispisuje rastav broja na proste faktore.*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            int x = a;
            List<int> djelitelji = new List<int>(); //svi djelitelji
            for(int i=1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    djelitelji.Add(i);
                }
            }
            foreach(int d in djelitelji)
            {
                x = a;
                int prost = 0;
                for(int j = 1; j < d; j++)
                {
                    if (d % j == 0)
                    {
                        prost++;
                    }
                }
                if (prost == 1)
                {
                    while ((float) x / d==(int)x/d && x/d!=0 )
                    {
                        Console.WriteLine("{0}", d);
                        x /= d;
                    }
                    
                }
                
            }
        }
    }
}

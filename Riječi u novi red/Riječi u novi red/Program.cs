/*Napišite program koji traži unos rečenice i zatim ispisuje svaku riječ iz rečenice u novi red.*/
using System;

namespace Riječi_u_novi_red
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Upiši rečenicu: ");
                string recenica = Console.ReadLine();
                string[] rijeci = recenica.Split(' ');
                int brojac = 0;
                for (int i = 0; i < rijeci.Length; i++)
                Console.WriteLine(rijeci[i]);
            }
        }
 }

    


/*Napišite program koji traži unos prirodnih brojeva sve dok se ne unese broj 0. Nakon toga unesene 
 parne brojeve sprema u datoteku parni.txt, a neparne u datoteku neparni.txt.*/
using System;
using System.Collections.Generic;
using System.IO;

namespace Par_Nepar_u_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Učitavam brojeve dok ne upišeš 0:");
            List<int> ucitanibrojevi = new List<int>();
            int a = int.Parse(Console.ReadLine());
            FileStream fs1 = new FileStream("parni.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("neparni.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);
            while (a != 0)
            {
                ucitanibrojevi.Add(a);
                a = int.Parse(Console.ReadLine());
            }
            foreach(int broj in ucitanibrojevi)
            {
                if (broj % 2 == 0)
                {
                    //Upiši u parni.txt
                    sw1.WriteLine(broj);
                }
                else
                {
                    //Upiši u neparni.txt
                    sw2.WriteLine(broj);
                }
            }
            sw1.Flush();
            sw1.Close();
            sw2.Flush();
            sw2.Close();
            fs1.Close();
            fs2.Close();
        }
    }
}

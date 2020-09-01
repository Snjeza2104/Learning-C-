/*Napišite program koji zapisuje u datoteke:
 3or7uNoviRed.txt - svaki broj u novi red
3or7SaZarezima.txt - svaki broj odvojen zarezom
sve brojeve iz intervala [0,100] koji su djeljivi s brojem 3 ili brojem 7*/
using System;
using System.IO;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi s 3 ili 7 u intervalu [0,100] su zapisani u 2 datoteke.");
            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);
            for(int i = 0; i <= 100; i++)
            {
                if(i%3==0 || i % 7 == 0)
                {
                    //Upiši u obje datoteke
                    sw.WriteLine(i);
                    sw2.Write(i + ", ");
                }
            }
            sw.Flush();
            sw2.Flush();
            sw.Close();
            sw2.Close();
            fs1.Close();
            fs2.Close();
        }
    }
}

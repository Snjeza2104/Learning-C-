/*Napišite program koji traži unos ocjene. Dok god unesena ocjena ne bude ispravno unesena
 (cijeli broj iz intervala [1,5]), program traži ponovni unos.*/
using System;

namespace Unos_ocjene
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena = 0;
            while(ocjena!=1 && ocjena!=2 && ocjena!=3 && ocjena!=4 && ocjena != 5)
            {
                Console.Write("Unesi ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());
            }
           
        }
    }
}

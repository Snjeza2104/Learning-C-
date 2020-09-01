/*Napišite program koji na početku traži da se unese broj predmeta za koje će se unositi ocjene za
 računanje završnog uspjeha (prosjeka) nekog učenika. Zatim se unose ocjene. Ako su sve unesene
ocjene pozitivne, program ispisuje njihov prosjek, a inače ispisuje "Uspjeh je nedovoljan!" Za pogrešno
unesenu ocjenu, program treba javiti grešku i zatražiti ponovni unos.*/
using System;

namespace Završni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0, negativni = 0, ocjena;
            Console.Write("Unesi broj predmeta da izračunam njihov prosjek ocjena");
            int broj = int.Parse(Console.ReadLine());
            for(int i = 1; i <= broj; i++)
            {
                Console.Write("Upiši {0}. ocjenu: ", i);
                ocjena = int.Parse(Console.ReadLine());
                if(ocjena==1 || ocjena==2 || ocjena==3 || ocjena==4 || ocjena == 5)
                {
                    zbroj += ocjena;
                    if (ocjena == 1)
                    {
                        negativni++;
                    }
                }
                else
                {
                    Console.WriteLine("Pogrešan unos.");
                    i--;
                }
            }
            if(negativni>0)
            {
                Console.WriteLine("Uspjeh je nedovoljan!");
            }
            else
            {
                Console.WriteLine("Prosjek je {0}.",(float)zbroj/broj);
            }
        }
    }
}

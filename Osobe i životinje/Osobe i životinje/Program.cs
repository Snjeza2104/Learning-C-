using System;

namespace Osobe_i_životinje
{
    interface IMojInterface
    {
        string PunoIme();
    }
    class Osoba: ICloneable, IDisposable, IComparable,IMojInterface
    {
        private string Ime;
        public string ime
        {
            get { return Ime; }
            set { Ime = value; }
        }
        private string Prezime;
        public string prezime
        {
            get { return Prezime; }
            set { Prezime = value; }
        }
        private Osoba Partner;
        public Osoba partner
        {
            get { return Partner; }
            set { Partner = value; }
        }

        public object Clone()
        {
            //Implementacija kloniranja
            Osoba klon = new Osoba();
            klon.ime = this.ime;
            klon.prezime = this.prezime;
            return klon;
        }

        public int CompareTo(object obj)
        {
            /*Metoda CompareTo trebala bi vratiti -1 ako je objekt manji od trenutnog
             (this), vraća 0 ako su jednaki, vraća 1 ako je objekt veći*/
            Osoba os = (Osoba)obj;
            return this.prezime.CompareTo(os.prezime);
        }

        public void Dispose()
        {
            /*Treba se riješiti svih referenci koje sadrži naša klasa, npr. otvorene datoteke,
             otvorene veze s bazom ili, u našem primjeru, moramo se riješiti partnera*/
            partner = null;
        }

        public string PunoIme()
        {
            string PunoIme = this.Ime + " " + this.Prezime;
            return PunoIme;
        }
    }

    class Zivotinja: IComparable, IMojInterface
    {
        private string NarodniNaziv;
        public string narodninaziv
        {
            get { return NarodniNaziv; }
            set { NarodniNaziv = value; }
        }
        private string LatinskiNaziv;
        public string latinskinaziv
        {
            get { return LatinskiNaziv; }
            set { LatinskiNaziv = value; }
        }

        public int CompareTo(object obj)
        {
            return this.latinskinaziv.CompareTo(((Zivotinja)obj).latinskinaziv);
        }

        public string PunoIme()
        {
            string PunoIme = this.narodninaziv + " " + this.latinskinaziv;
            return PunoIme;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.ime = "Pero";

            Osoba osoba2 = osoba1;
            osoba2.ime = "Ana";

            //Objekti se prosljeđuju po referenci, pa se ispisuje "Ana" u slijedećem kodu
            Console.WriteLine(osoba1.ime);

            //Ispitajmo dijele li naši objekti osoba1 i osoba2 istu referencu (adresu) - TRUE
            Console.WriteLine(object.ReferenceEquals(osoba1, osoba2));

            //A ako radimo preko novoimplementirane metode CLONE
            osoba1.ime = "Pero";
            Osoba osoba3 = (Osoba)osoba1.Clone();
            osoba3.ime = "Ana";

            //Sada je objekt x ostao netaknut
            Console.WriteLine(osoba1.ime);
            //i naši objekti x i z NE dijele istu referencu (adresu) - FALSE
            Console.WriteLine(object.ReferenceEquals(osoba1, osoba3));

            //Koristimo novo svojstvo Partner
            osoba1.partner = osoba3;
            Console.WriteLine(osoba1.ime + " Partner: " + osoba1.partner.ime);
            osoba3.partner = osoba1;
            Console.WriteLine(osoba3.ime + " Partner: " + osoba3.partner.ime);

            //i vidimo da objekti osoba3 i osoba1.partner dijele istu referencu - TRUE
            Console.WriteLine(object.ReferenceEquals(osoba3, osoba1.partner));

            //Demonstriramo metodu DISPOSE
            osoba1.Dispose();

            //Sada više objekti ne dijele istu referencu
            Console.WriteLine(object.ReferenceEquals(osoba3, osoba1.partner));

            /*Sada zahvaljujući interfejsu mogu pristupiti skupini više različitih
             objekata ako svi oni imaju implementiranu određenu metodu*/

            //1) Npr. metoda DISPOSE
            IDisposable dis = osoba1;
            dis.Dispose();

            //2) Primjer korištenja mog vlastitog interfejsa
            Osoba osoba = new Osoba();
            osoba.ime = "Matej";
            osoba.prezime = "Matić";

            Zivotinja zivotinja = new Zivotinja();
            zivotinja.narodninaziv = "Divlja svinja";
            zivotinja.latinskinaziv = "Sus scrofa";

            System.Collections.ArrayList lista = new System.Collections.ArrayList();
            lista.Add(osoba);
            lista.Add(zivotinja);

            foreach(IMojInterface element in lista)
            {
                IspisiPunoIme(element);
            }
            Console.ReadKey();

        }
        private static void IspisiPunoIme(IMojInterface objekt)
        {
            Console.WriteLine(objekt.PunoIme());
        }
    }
}

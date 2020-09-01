/*Klasa Osoba
    Svojstva
        Ime (string)
        Prezime (string)
        DatumRodjenja (DateTime)
        Starost (int) ReadOnly svojstvo
        Spol (spol) - tip spol je Enumeracija
    Metode
        Konstruktor koji traži parametre ime i prezime
    Događaji
        Rođendan - podiže se na promjenu svojstva DatumRodjenja*/
using System;

namespace Rodjendan
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Jure", "Perić");
            osoba.datumrodjenja = new DateTime(2020,8,28);
            osoba.Spol = Spol.Muski;
            Console.WriteLine(osoba.starost/365+" godina ");

            //Implementacija događaja -1
            osoba.Rodjendan += new Osoba.RodjendanDelegat(os_Rodjendan);
            osoba.datumrodjenja = new DateTime(2020,8,31);
            osoba.Rodjendan -= new Osoba.RodjendanDelegat(os_Rodjendan);
        }
        static void os_Rodjendan(object sender, EventArgs e)
        {
            Osoba os = (Osoba)sender;
            Console.WriteLine("SRETAN ROĐENDAN, {0}!", os.ime);
        }

        public enum Spol
        {
            Muski,
            Zenski
        }
        class Osoba
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
            private DateTime DatumRodjenja;
            public DateTime datumrodjenja
            {
                get { return DatumRodjenja; }
                set { DatumRodjenja = value;
                    //Ako je nova vrijednost današnji datum, podiže se događaj
                    if(DatumRodjenja.ToString("dd MM")==DateTime.Now.ToString("dd MM"))
                    {
                        if (Rodjendan != null)
                        {
                            Rodjendan(this, new EventArgs());
                        }
                    }
                }
            }
            private int Starost;
            public int starost
            {
                get
                {
                    TimeSpan ts = DateTime.Now - this.DatumRodjenja;
                    return (int)ts.TotalDays;
                }
            }
            private Spol spol;
            public Spol Spol
            {
                get { return spol; }
                set { spol = value; }
            }
            public Osoba(string ime, string prezime)
            {
                this.Ime = ime;
                this.Prezime = prezime;
            }
            public delegate void RodjendanDelegat(object sender, EventArgs e);
            public event RodjendanDelegat Rodjendan;
        }
        
    }
}

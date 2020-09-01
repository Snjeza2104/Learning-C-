/*Napravite klasu Osoba
    svojstva
        Ime
        Prezime
    metode
        Pozdrav(ime) - potprogram koji na ekranu ispisuje pozdravnu poruku "Dobar dan, ime!"
        Inicijali(ime) - funkcija koja vraća inicijale osobe
        Kapitalizacija(ime) - funkcija koja vraća proslijeđeni tekst tako da je u svakoj riječi
                                početno slovo veliko, a ostala slova su mala.*/
using System;

namespace Osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.ime = "vLaTkO";
            osoba.prezime = "Vukina";
            osoba.Pozdrav(osoba.ime);
            Console.WriteLine(osoba.Inicijali(osoba.ime));
            Console.WriteLine(osoba.Kapitalizacija(osoba.ime));
        }
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
        public void Pozdrav(string ime)
        {
            Console.WriteLine("Dobar dan, "+ime+"!");
        }
        public string Inicijali(string ime)
        {
            return ime[0]+". "+prezime[0]+". ";
        }
        public string Kapitalizacija(string ime)
        {
            return ime.Substring(0,1).ToUpper() + ime.Substring(1, ime.Length - 1).ToLower();
        }
    }
}

using System;
using System.Collections;
using System.ComponentModel.Design;

namespace Vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            //Na početku dižemo zastavicu za unos
            char unos = 'd';

            //Instanciramo liste
            ArrayList vozila = new ArrayList();
            Automobili automobili = new Automobili();

            //Dok je zastavica za unos dignuta, učitavamo vozila
            while(unos=='d' || unos == 'D')
            {
                //Odabir tipa vozila
                Console.WriteLine("Za unos automobila odaberite 1, a za unos broda odaberite 2!");
                Console.Write("Vaš odabir: ");
                char odabir = Console.ReadKey(false).KeyChar;
                Console.WriteLine();

                if(odabir=='1')
                {
                    //Instanciramo objekt klase Automobil
                    Automobil automobil = new Automobil();

                    //Inicijalizacija objekta automobila
                    Console.Write("Unesite naziv automobila:");
                    automobil.naziv = Console.ReadLine();
                    Console.Write("Unesite boju automobila: ");
                    automobil.boja = Console.ReadLine();
                    Console.Write("Unesite KS automobila: ");
                    automobil.konjskesnage = int.Parse(Console.ReadLine());
                    Console.Write("Unesite ccm automobila: ");
                    automobil.ccm = double.Parse(Console.ReadLine());

                    //Novi objekt klase Automobil dodajemo u obje liste
                    vozila.Add(automobil);
                    automobili.Add(automobil);
                }
                else if (odabir == '2')
                {
                    //Instanciranje objekta klase brod
                    Brod brod = new Brod();
                    //Delegiranje događaja
                    brod.NaPromjenuIstisnine += new Brod.NaPromjenuIstisnineDelegat(brod_NaPromjenuIstisnine);

                    Console.Write("Unesite naziv broda: ");
                    brod.naziv = Console.ReadLine();
                    Console.Write("Unesite boju broda: ");
                    brod.boja = Console.ReadLine();
                    Console.Write("Unesite KS broda: ");
                    brod.konjskesnage = int.Parse(Console.ReadLine());
                    Console.Write("Unesite istisninu broda: ");
                    brod.istisnina = double.Parse(Console.ReadLine());

                    //Novi objekt klase Brod dodajemo u listu vozila
                    vozila.Add(brod);
                }
                else
                {
                    Console.WriteLine("Pogrešan odabir!");
                }
                Console.Write("Želite li unositi još vozila (D/N)?");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            //Ispis liste vozila
            Console.WriteLine("Sva vozila:");
            foreach(object objekt in vozila)
            {
                //Elemente liste koji su klase Object moramo "kastati"
                Vozilo vozilo = (Vozilo)objekt;

                Console.WriteLine("Naziv: {0}, Boja: {1}, KS: {2}, KW: {3}", vozilo.naziv,
                    vozilo.boja, vozilo.konjskesnage, vozilo.KStoKW(vozilo.konjskesnage));
            }

            //Ispis kolekacija automobili
            Console.WriteLine("Automobili: ");
            foreach(Automobil automobil in automobili)
            {
                Console.WriteLine(automobil.ToString());
            }
            Console.ReadKey();
        }
        static void brod_NaPromjenuIstisnine (object sender, EventArgs e)
        {
            Console.WriteLine("Brod je promijenio podatke: {0}", ((Brod)sender).istisnina);
        }
    }
    class Vozilo
    {
        private string Naziv;
        public string naziv
        {
            get { return Naziv; }
            set { Naziv = value; }
        }
        private string Boja;
        public string boja
        {
            get { return Boja; }
            set { Boja = value; }
        }
        private int KS;
        public int konjskesnage
        {
            get { return KS; }
            set { KS = value; }
        }
        public double KStoKW(int KS)
        {
            return KS * 0.736;
        }
    }
    class Automobil: Vozilo
    {
        private double Ccm;
        public double ccm
        {
            get { return Ccm; }
            set { Ccm = value; }
        }
        public override string ToString()
        {
            return this.naziv + ", " + this.konjskesnage;
        }
    }
    class Brod: Vozilo
    {
        private double Istisnina;
        public double istisnina
        {
            get { return Istisnina; }
            set { Istisnina = value;
                if (NaPromjenuIstisnine != null)
                {
                    NaPromjenuIstisnine(this, new EventArgs());
                }
            }
        }
        public delegate void NaPromjenuIstisnineDelegat(object sender, EventArgs e);
        public event NaPromjenuIstisnineDelegat NaPromjenuIstisnine;
    }
    public class Automobili : System.Collections.CollectionBase
    {
        public int Add(object auto)
        {
            return base.InnerList.Add(auto);
        }
        //Implementacija indeksera
        public object this[int index]
        {
            get
            {
                return (Automobil)base.InnerList[index];
            }
        }
        public void Remove(object automobil)
        {
            InnerList.Remove(automobil);
        }

    }
}

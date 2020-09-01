/*Napravit klasu Automobil unutar konzolne aplikacije sa sljedećim svojstvima:
 public class Automobil{
    public string Marka{get; set;}
    public string Model{get; set;}
    public int Zapremnina {get; set;}
}
U konzolnom prozoru omogućite unos novih automobila. Nakon svakog novog unosa pitajte: "Želite li upisati
novi automobil (d)" Svi ostali znakovi uvjetuju izlazak iz petlje. Nakon izlaska iz petlje je na
konzolnom prozoru potrebno ispisati sve modele automobila poredane po modelu vozila uzlazno, ali
samo one kojima je zapremnina veća od 1600 ccm.?"
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Automobili
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();
            Console.WriteLine("Upišite marku automobila: ");
            automobil.Marka = Console.ReadLine();
            Console.WriteLine("Upišite model automobila: ");
            automobil.Model = Console.ReadLine();
            Console.WriteLine("Upišite zapremninu automobila: ");
            automobil.Zapremnina =int.Parse(Console.ReadLine());
            List<Automobil> Automobili = new List<Automobil>();
            Automobili.Add(automobil);
            Console.WriteLine("Želite li upisati novi automobil(d)");
            string izbor = Console.ReadLine();
            while(izbor=="d" || izbor == "D")
            {
                //Još upisuje automobile
                Automobil automobil2 = new Automobil();
                Console.WriteLine("Upišite marku automobila: ");
                automobil2.Marka = Console.ReadLine();
                Console.WriteLine("Upišite model automobila: ");
                automobil2.Model = Console.ReadLine();
                Console.WriteLine("Upišite zapremninu automobila: ");
                automobil2.Zapremnina = int.Parse(Console.ReadLine());
                Automobili.Add(automobil2);
                Console.WriteLine("Želite li upisati novi automobil(d)");
                izbor = Console.ReadLine();
            }

            //LINQ upit na Automobili listi
            List<Automobil> trazeniAuti =(from auto in Automobili orderby auto.Model descending
                                          where auto.Zapremnina>1600 select auto).ToList();
            foreach(Automobil a in trazeniAuti)
            {
                Console.WriteLine("Marka: "+a.Marka);
                Console.WriteLine("Model: " + a.Model);
                Console.WriteLine("Zapremnina: " + a.Zapremnina);
            }

        }
    }
    public class Automobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Zapremnina { get; set; }
    }
}

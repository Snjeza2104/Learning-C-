using System;

namespace Enumeracija_spol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum Spol
    {
        Muski,
        Zenski
    }
    public class Osoba
    {
        private Spol spol;
        public Spol Spol
        {
            get { return spol; }
            set { spol = value; }
        }
    }
}

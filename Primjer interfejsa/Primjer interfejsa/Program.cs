using System;

namespace Primjer_interfejsa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface ImeInterfejsa
    {
        void PrimjerMetode();
    }
    class ImplementacijskaKlasa : ImeInterfejsa
    {
        public void PrimjerMetode()
        {
            //throw new NotImplementedException();
            //stvarna implementacija metode/svojstva
        }
    }
}

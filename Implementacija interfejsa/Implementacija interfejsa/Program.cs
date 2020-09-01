/*Program koji demonstrira implementaciju interfejsa*/
using System;

namespace Implementacija_interfejsa
{
    //Interfejs IPoint sadrži deklaracije svojstava odgovornih 
    //za postavljanje i vraćanje vrijednosti polja (koordinata).
    interface IPoint
    {
        //Potpisi svojstava:
        int x
        {
            get;
            set;
        }
        int y
        {
            get;
            set;
        }
    }
    //Klasa Point sadrži implementaciju tih svojstava
    class Point: IPoint
    {
        //Polja
        private int _x;
        private int _y;

        //Konstruktor
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        //Implementacija svojstava
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
    class Program
    {
        //U glavnom programu instanciran je objekt p klase Point koji metodom PrintPoint
        //ispisuje na ekran koordinate točke p.

        //U definiciji metode PrintPoint kao parametar navedena je varijabla p tipa IPoint,
        //dok kod poziva te metode u glavnom programu prosljeđujete objekt p klase Point.
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x,p.y);
        }
        static void Main()
        {
            Point p = new Point(2, 3);
            Console.Write("Koordinate točke: ");
            PrintPoint(p);
            Console.ReadKey();
        }
    }
}

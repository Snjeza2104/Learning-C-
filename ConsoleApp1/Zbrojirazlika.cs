using System;
namespace ConsoleApp1
{
	class Zbrojirazlika
	{
		static void Main()
        {
			Console.Write("Upiši prvi broj:");
			int a = intParse(Console.Read());
			Console.Write("Upiši drugi broj:");
			int b = intParse(Console.Read());
			Console.WriteLine("Zbroj je {0}, a razlika {1}, a+b, a-b);
		}
	}
}

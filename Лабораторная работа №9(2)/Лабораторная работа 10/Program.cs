using System;

namespace Лабораторная_работа_10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Clear();
			Console.Title = "Лабораторная работа №9";
			Suspitions p1 = new Suspitions("Бенхард Джонатан Вегард", "Наследство", 3);
			p1.UlPlus(4);
			p1.UlMinus(2);
			p1.DrowEmblema();
			Console.WriteLine("\n \n \n \n \n ");
			Incendent k1 = new Incendent("Бруклинский мост", DateTime.Today, 25);
			k1.UlPlus(5);
			k1.UlMinus(2);
			k1.DrowEmblema();
			Console.WriteLine("\n \n \n \n \n ");
			Console.ReadKey(); 
		}
	}
}

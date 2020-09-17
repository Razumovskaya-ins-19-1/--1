using System;

namespace Индивидуальное_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Лабораторная работ №1 Разработка консольного приложения");
            Console.WriteLine("Разумовская Людмила Евгеньевна");
            Console.WriteLine("ИНС-б-о-19-1");
            Console.WriteLine("14.11.2001");
            Console.WriteLine("Республика Калмыкия город Городовиковск");
            Console.WriteLine("Математика");
            Console.WriteLine("Ведение канала на YouTube");
            Console.ReadKey();
            Console.WriteLine("Задание 2");
            int x = 15;
            int y = 26;
            int z = 63;
            int R;
            R = 2 * x + 2 * y - 4 * x * y + z;
            Console.WriteLine("Значение x равно {0}", x);
            Console.WriteLine("Значение y равно {0}", y);
            Console.WriteLine("Значение z равно {0}", z);
            Console.WriteLine("R =2*x+2*y-4*x*y+z= 2*{0}+2*{1}-4*{0}*{1}+{2}={3}", x, y, z, R);
            Console.ReadKey();
        }
    }
}

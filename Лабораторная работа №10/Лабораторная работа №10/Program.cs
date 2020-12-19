using System;

namespace Лабораторная_работа__10
{
  class Program
   {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            float c1, c2;
            Библиотека mtr1 = new Библиотека();
            mtr1.Generator(2, 3);
            mtr1.Save(@"Matrix1.txt");
            c1 = mtr1.Sum("Matrix1.txt");

            Библиотека mtr2 = new Библиотека();
            mtr2.Generator(3, 2);
            mtr2.Save(@"Matrix2.txt");
            c2 = mtr2.Sum("Matrix2.txt");

            Console.WriteLine("Сумма элементов с четной суммой индексов первой матрицы равна {0}", c1);
            Console.WriteLine("Сумма элементов с четной суммой индексов второй матрицы равна {0}", c2);
            Console.WriteLine("Сумма элементов с четной суммой индексов двух матриц {0}", (c1 + c2));
        }
    }
}

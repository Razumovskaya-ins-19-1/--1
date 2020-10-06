using System;
using System.IO;

namespace Лабораторная_работа__5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save = Console.Out;
            var new_v = new StreamWriter(@"input.txt");
            Console.SetOut(new_v); 
            int N, M; 
            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int a;
            for(int i=0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    a = r.Next(-1000, 1000);
                    Console.Write(a+" ");
                }
                Console.WriteLine();
            }
            Console.SetOut(save); new_v.Close();
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter("output.txt");
            var new_in = new StreamReader("input.txt");
            Console.SetOut(new_out); Console.SetIn(new_in);
            int[,] mas = new int[M, N];
            Console.WriteLine("Матрица:");
            for (int i=0; i<M; i++)
            {
                string str = Console.ReadLine();
                string[] str_el = str.Split(' ');
                for (int j=0; j<N; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_el[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднее арифметическое столбцов:");
            for (int j=0; j<N; j++)
            {
                double sa = 0;
                for(int i=0; i<M; i++)
                {
                    sa += mas[i, j];

                }
                sa = sa / M;
                Console.Write(string.Format("{0:0.00 }", sa));
            }
            Console.WriteLine("\nМодифицированная матрица: \n");
            for (int i=0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    if (mas[i, j] % 3 == 0) Console.Write("3 ");
                    else if (mas[i, j] % 5 == 0) Console.Write("5 ");
                    else Console.Write("0 ");
                }
                Console.WriteLine();
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();


        }
    }
}

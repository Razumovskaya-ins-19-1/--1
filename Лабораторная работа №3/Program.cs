using System;
using System.IO;
namespace Лабораторная_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter("output");
            var new_in = new StreamReader("input");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            int N=1, t=0;
            double Z=0, X=0, Y=0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            int i=1;
            switch (t)
            {
                case 0:
                    {
                        for (i = 1; i <= N; i++)
                            if (i % 2 == 0)
                                Z += (-1) * Math.Pow(Y-X, i*2)/ ((i + i - 1) * (2 * i + 1));
                            else Z += Math.Pow(X - Y, i*2) / ((i+i-1)*(2*i+1));
                    }
                    Console.WriteLine(String.Format("{0:0.0000000}", Z));
                    break;
                case 1:
                    {
                        while (i <= N)
                        {
                            if (i % 2 == 0)
                                Z += (-1) * Math.Pow(Y - X, i * 2) / ((i + i - 1) * (2 * i + 1));
                            else Z += Math.Pow(X - Y, i * 2) / ((i + i - 1) * (2 * i + 1));
                            i++;
                        }
                    }
                    Console.WriteLine(String.Format("{0:0.0000000}", Z));
                    break;
                case 2:
                    {
                        do
                        {
                            if (i % 2 == 0)
                                Z += (-1) * Math.Pow(Y - X, i * 2) / ((i + i - 1) * (2 * i + 1));
                            else Z += Math.Pow(X - Y, i * 2) / ((i + i - 1) * (2 * i + 1));
                            i++;
                        }
                        while (i <= N);
                    }
                    Console.WriteLine(String.Format("{0:0.0000000}", Z));
                    break;
                default:
                    Console.WriteLine("Введено неверное t");
                    break;
            }
            
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();

        }

    }
}

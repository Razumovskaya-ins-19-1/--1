using System;
using System.IO;
namespace Лабораторная_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
           double a, b, c, d, e, s, k;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(c, 2) - Math.Pow(e, 2) == 0)
                Console.WriteLine("ERROR");
            else
            {
                s = Math.Pow(a, 2) / (Math.Pow(c, 2) - Math.Pow(e, 2));
                Console.WriteLine(String.Format("{0:0.000}", s));
            }
            if ((Math.Pow(c, 2) - Math.Pow(d, 3) <= 0) || (a - Math.Pow(c, 2) < 0))
                Console.WriteLine("ERROR");
            else
            {
                k = Math.Sqrt(a - Math.Pow(c, 2)) / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(d, 3));
                Console.WriteLine(String.Format("{0:0.000}", k));
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();
        }
    }
}

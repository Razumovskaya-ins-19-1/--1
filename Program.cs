using System;
using System.IO;  

namespace Лабораторная_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"Out.txt");
            var new_in = new StreamReader(@"In.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Cylinder C = new Cylinder();
            C.Load();
            C.Info();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}

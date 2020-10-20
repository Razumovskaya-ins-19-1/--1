using System;
using System.IO; 

namespace Лабораторная_работа__8
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
            Point p1, p2;
#if DEBUG
            p2 = new Point(2, 6, 5, 4);
            p2.Info(ConsoleColor.White, ConsoleColor.DarkMagenta);
#endif
#if !DEBUG
                p1=Point.File();
                p1.Info();
                p2= new Point(8, 5, 6, 9);
                p2.Info();
#endif
#if !DEBUG
                Console.SetOut(save_out); new_out.Close();
                Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
            
        }
    }
}

using System;
using System.IO;

namespace Лабораторная_работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
             TextWriter saveout = Console.Out;
             var new_out = new StreamWriter("input.txt");
             Console.SetOut(new_out);
             Console.WriteLine(n);
            Random r = new Random();
            double a = 0;
             int i;
            for (i=0; i < n; i++) 
             {
                a = Convert.ToDouble(r.Next(-1000000, 1000000) / 10.00); 
                    Console.Write(a + " ");
             }
             Console.SetOut(saveout); new_out.Close();
             TextReader save_in = Console.In;
             TextWriter save_out = Console.Out;
             var newout = new StreamWriter("output.txt");
             var newin = new StreamReader("input.txt");
             Console.SetOut(newout);
             Console.SetIn(newin);
             int N = Convert.ToInt32(Console.ReadLine());
             string str = Console.ReadLine();
             string [] str_el = str.Split(' ');
             double [] mas = new double[N]; 
             for (i = 0; i < N; i++)
             {
                 mas[i] = Convert.ToDouble(str_el[i]);
                 
             } 
                  double Max = mas[0];
                   for (i=0; i<N; i++)
                   {
                       if (mas[i] > Max)
                       {
                           Max = mas[i];
                       }
                   }
            Console.WriteLine(Max);
           
            int k = 0;
            for (i = 0; i < N; i++)
                if (Max != mas[i])
            { if (mas[i] >= 0)
                {
                    if (Max - mas[i] <= 1000)
                    {
                        Console.Write(mas[i] + " "); k++;
                    }
                }
            else
                {
                    if (Max + ((-1)* mas[i]) <= 1000)
                    {
                        Console.Write(mas[i] + " "); k++;
                    }
                }
            }
            if (k==0)
            {
                Console.Write("NO");
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                if (Math.Abs(mas[i])>5000)
                {
                    Console.Write("+");
                }
                else { Console.Write("-"); }
            }

                Console.SetOut(save_out); newout.Close();
             Console.SetIn(save_in); newin.Close();

        }
        }
    }


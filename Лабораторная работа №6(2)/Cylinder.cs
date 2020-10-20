using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_6
{
    class Cylinder
    {
        private double r, h;
        private const double pi = 3.14;

        public double Area()
        {
            return 2 * pi * r * (r + h);
        }
        public double Volume()
        {
            return pi * Math.Pow(r, 2) * h;
        }
        public void Info()
        {
            String str = "     **********     \n" +
                         "    *          *    \n" +
                         "    **        **    \n" +
                         "    * ******** *    \n" +
                         "    *          *    \n" +
                         "    *          *    \n" +
                         "    *          *    \n" +
                         "    *          *    \n" +
                         "    *          *    \n" +
                         "     **********    \n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("R={0:0.000}, H={1:0.000}", r, h));
            Console.WriteLine(string.Format("S={0:0.000}", Area()));
            Console.WriteLine(string.Format("V={0:0.000}", Volume()));
        }
        public void Load()
        {
            r = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
        }
    }
}

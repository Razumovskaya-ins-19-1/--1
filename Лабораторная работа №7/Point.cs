using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__8
{
    class Point 
    {
        private double x1, y1, x2, y2;
        private Point() { }


        public Point(double px1, double py1, double px2, double py2)
        {
             
            x1 = px1;
            y1 = py1;
            x2 = px2;
            y2 = py2;
        }
        public void Load()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public static Point File()
        { 
            double x11= Convert.ToDouble(Console.ReadLine());
            double y11 = Convert.ToDouble(Console.ReadLine());
            double x22 = Convert.ToDouble(Console.ReadLine());
            double y22 = Convert.ToDouble(Console.ReadLine());
            return new Point(x11, y11, x22, y22);
        }
        public double distance2()
        {
            return Math.Sqrt(x1 * x1 + y1 * y1); 
        }
        public double distance1()
        {
            return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
        }
        public void Info()
        {
            Console.WriteLine(string.Format(" Первая точка X1={0:0.000}, Y1={1:0.000}", x1, y1));
            Console.WriteLine(string.Format(" Вторая точка X2={0:0.000}, Y2={1:0.000}", x2, y2));
            Console.WriteLine(string.Format(" Расстояние от начала координат до первой точки: S={0:0.000}", distance2()));
            Console.WriteLine(string.Format(" Расстояние  между точками: d={0:0.000}", distance1()));
        }
       public void Info(ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Clear();
            Info();
        }
    }
}

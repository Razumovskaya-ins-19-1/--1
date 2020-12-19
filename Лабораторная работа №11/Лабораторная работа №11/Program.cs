using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Лабораторная_работа__11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader potok = new StreamReader("lr11_24.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"out.txt");
            Console.SetOut(new_out);
#endif
            List<Goods> all = new List<Goods>();
            try
            {
                string line = potok.ReadLine();
                while ((line = potok.ReadLine()) != null)
                {
                    all.Add(Goods.Creat(line));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("******Задача1*******");
            float Max_prosr = (from p in all
                               where p.prosr == true
                               select p.price).Max();
            Goods rich_goods1 = (from p in all
                                where (p.prosr == true) && (p.price == Max_prosr)
                                select p).First();
            Console.WriteLine(rich_goods1);

            float Max_no_prosr = (from p in all
                               where p.prosr == false
                               select p.price).Max();
            Goods rich_goods2 = (from p in all
                                where (p.prosr == false) && (p.price == Max_no_prosr)
                                select p).First();
            Console.WriteLine(rich_goods2);

            Console.WriteLine("******Задача2*******");
            int outcateg = all.FindAll(p => p.categ == category.Категории_нет).ToList().Count;
            Console.WriteLine("Количество товара без категории: {0}", outcateg);

            Console.WriteLine("******Задача3*******");
            float A = (from p in all
                                  where (p.categ == category.A) && (p.skid == true)
                                  select p.price).Max();
            Goods goodsA = (from p in all
                                 where (p.categ == category.A) && (p.price == A) && (p.skid == true)
                            select p).First();
            Console.WriteLine("Самый дорогой товар в категории А: \n  {0}", goodsA);

            float B = (from p in all
                       where (p.categ == category.B) && (p.skid == true)
                       select p.price).Max();
            Goods goodsB = (from p in all
                            where (p.categ == category.B) && (p.price == B) && (p.skid == true)
                            select p).First();
            Console.WriteLine("Самый дорогой товар в категории B: \n {0}", goodsB);

            float C = (from p in all
                       where (p.categ == category.C) && (p.skid == true)
                       select p.price).Max();
            Goods goodsC = (from p in all
                            where (p.categ == category.C) && (p.price == C) && (p.skid == true)
                            select p).First();
            Console.WriteLine("Самый дорогой товар в категории C: \n {0}", goodsC);

            float D = (from p in all
                       where (p.categ == category.D) && (p.skid == true)
                       select p.price).Max();
            Goods goodsD = (from p in all
                            where (p.categ == category.D) && (p.price == D) && (p.skid == true)
                            select p).First();
            Console.WriteLine("Самый дорогой товар в категории D: \n {0}", goodsD);

            Console.WriteLine("******Задача4*******");
            float summa = (from p in all
                           where (p.skid == true)
                           select (p.price) * (p.kol)).Sum();
            Console.WriteLine("Объем товаров в валюте с учётом скидки {0}", summa);
#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif 
        }
    }
}

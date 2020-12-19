using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__11
{
    enum category
    {
        A,
        B,
        C,
        D,
        Категории_нет
    }
    class Goods
    {
        string ID { get; set; }
        string Name { get; set; }
        public category categ { get; set; }
        public int kol { get; set; }
        public float price { get; set; }
        public Boolean prosr { get; set; }
        public Boolean skid { get; set; }
        public static Goods Creat(string str)
        {
            Goods g = new Goods();
            if (str.EndsWith(","))
                str += "false";
            while (str.IndexOf(",,") > 0)
            {
                str = str.Insert((str.IndexOf(",,") + 1), "false");
            }
              string[] el = str.Split(',');
               if (el.Length > 7)
               {
                for (int t = el.Length - 7; t != 0; t--)
                {
                    el[1] += ", " + el[2];
                    for (int i = 3; i < el.Length; i++)
                        el[i - 1] = el[i];
                }
               }
               g.ID = el[0].Trim(); 
               g.Name = el[1].Trim();
               string tmp = el[2].Trim();
               switch (tmp)
               {
                   case "A": { g.categ = category.A; break; };
                   case "B": { g.categ = category.B; break; };
                   case "C": { g.categ = category.C; break; };
                   case "D": { g.categ = category.D; break; };
                   default: { g.categ = category.Категории_нет; break; };
               }
               g.kol = Convert.ToInt32(el[3].Trim());
               g.price = Convert.ToSingle(el[4].TrimStart('$').Replace('.', ','));
               g.prosr = Convert.ToBoolean(el[5]);
               g.skid = Convert.ToBoolean(el[6]);
               return g;
           }

           public override string ToString()
           {
               string s = string.Format(
                   "*******************************************************\n" +
                   "ID: {0}, Наименование: {1}, Категория: {2}, \n" +
                   "Количество: {3}, Цена: ${4},\n" +
                   "Признак просроченности: {5}, Наличие скидки: {6}",
                   ID, Name, categToStr(categ), kol, price, prosrToStr(prosr), skidToStr(skid));
               return s;
           }
           private static string categToStr(category tmp)
           {
               switch (tmp)
               {
                   case category.A: return "A";
                   case category.B: return "B";
                   case category.C: return "C";
                   case category.D: return "D";
                   default: return "Категории нет";
               }
           }
           private static string prosrToStr(Boolean h)
           {
               if (h == true) return "есть";
               else return "нет";
           }
           private static string skidToStr(Boolean h)
           {
               if (h == true) return "есть";
               else return "нет";
           } 
       }
        }
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataTier
{          
    public class Поездка
    {   
        public string Транспорт { get; set; }
        public string Пункт_отправки { get; set; }
        public string Пункт_назначения { get; set; }
        public float Стоимость { get; set; }
        public static Поездка Create(string str)
        {
            Поездка trip = new Поездка();
            string[] el = str.Split('*');
            trip.Транспорт = el[0].Trim();
            trip.Пункт_отправки = el[1].Trim();
            trip.Пункт_назначения = el[2].Trim();
            el[3] = el[3].Replace('.', ',');
            trip.Стоимость = Convert.ToSingle(el[3]);
            return trip; 
        }
    }

    public class Все_поездки
    {

        public static List<Поездка> Получить_все_поездки(StreamReader txr)
        {
            //TextReader save_in = Console.In;
            //StreamReader txr = new StreamReader(@"data.txt");
            //Console.SetIn(txr);
            List<Поездка> list = new List<Поездка>();
            string line;
                while ((line = txr.ReadLine()) != null)
                {
                    list.Add(Поездка.Create(line));
                }
                return list;

         //Console.SetIn(save_in);
         //   txr.Close();
        }

        public static void Сохранить_товары(List<Поездка> поездки)
        {

        }
   
    }

}

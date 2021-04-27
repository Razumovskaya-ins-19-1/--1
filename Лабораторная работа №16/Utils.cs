//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Лабораторная_работа__16
//{
//    class Utils
//    {
//        private static Dictionary<int, string> dict;
//        static Utils()
//        {
//            if (dict==null)
//            {
//                dict = new Dictionary<int, string>(5);
//                dict.Add(0, "Продукты");
//                dict.Add(1, "Бытовая химия");
//                dict.Add(2, "Одежда");
//                dict.Add(3, "Фрукты");
//                dict.Add(4, "Полиграфия");
//            }
//        }
//        public static String GetGroupByNumber(int number)
//        {
//            if (dict.ContainsKey(number))
//                return dict[number];
//            else
//                return "Номера не существует";
//        }
//    }
//}

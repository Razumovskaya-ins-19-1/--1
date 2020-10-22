using System;

namespace Лабораторная_работа__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Serves[] Сервис = new Serves[8];
            Сервис[0] = new Serves(100, Valuta.Дол, Srochnost.Краткосрочно, DateTime.Today);
            Сервис[1] = new Serves();
            Сервис[2] = new Продажи(200, Valuta.Евр, Srochnost.Не_имеет_значения, DateTime.Today, 10, 25);
            Сервис[3] = new Продажи();
            Сервис[4] = new Лизинг(1000, Valuta.Руб, Srochnost.Долгосрочно, DateTime.Today, Vid.Финансовый);
            Сервис[5] = new Лизинг();
            Сервис[6] = new Кредит(100000, Valuta.Евр, Srochnost.Краткосрочно, DateTime.Today, Plat.Кредитоспособный);
            Сервис[7] = new Кредит();
            for (int i = 0; i < Сервис.Length; i++)
            {
                Сервис[i].Col();
                Console.WriteLine(">>>>>>>>>>>>>>>>>    " + Сервис[i].GetType().Name);
            Console.WriteLine(Сервис[i].Sum);
            Console.WriteLine(Сервис[i].Сведения);
            Console.WriteLine("\n");
                
            }
        }
             
             
    }
        
    
}

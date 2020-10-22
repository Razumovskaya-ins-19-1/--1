using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Лабораторная_работа__8
{
    class Serves
    {
        public Serves(int pCost, Valuta pV, Srochnost pSr, DateTime pD)
        {
            cost = pCost;
            Валюта = pV;
            Срочность = pSr;
            Дата_подачи_заявки = pD;
        }
        public Serves()
        {
            cost = 0;
            Срочность = Srochnost.Не_имеет_значения;
            Валюта = Valuta.Руб;
            Дата_подачи_заявки = DateTime.Today;
            
        }
        protected int cost;
        protected Srochnost Срочность;
        protected Valuta Валюта;
        protected DateTime Дата_подачи_заявки;

        public virtual string Sum
        {
            get { return Convert.ToString(cost) + Валюта; } 
        }
           public string  Сведения
        {
            get
            {
                return "Срочность:" + Срочность.ToString() + " Дата подачи заявки:" + Дата_подачи_заявки.ToString();
            }
        }
        public virtual void Col()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            
            

        }
    }
    
   
            
        
    
}

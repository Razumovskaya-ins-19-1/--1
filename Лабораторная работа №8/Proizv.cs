using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Лабораторная_работа__8
{
    class Продажи : Serves
    {
        protected int Количество, Скидка;
        public Продажи() : base()
        {
            Количество = 0;
            Скидка = 0;
        }
        public Продажи(int pCost, Valuta pV, Srochnost pS, DateTime pD, int pK, int pC) : base(pCost, pV, pS, pD)
        {
            Количество = pK;
            Скидка = pC;
        }
        public override string Sum
        {
            get
            {
                return "Стоимость:" + base.Sum + $" Количество:{Количество}" +  $" Скидка:{Скидка}% " + " Конечная сумма: " + Convert.ToString((100 - Скидка)*0.01 * cost*Количество);
            }
        }
    }
    class Лизинг : Serves
    {
        public Vid Вид;
        public Лизинг() : base()
        {
            Вид = Vid.Никакой;
        }
        public Лизинг(int pCost, Valuta pV, Srochnost pS, DateTime pD, Vid pVid) : base(pCost, pV, pS, pD)
        {
            Вид = pVid;
        }
        public override string Sum
        {
            get
            {
                return base.Sum + ", Вид лизинга: " + Вид.ToString();
            }
        }
    }
    class Кредит : Serves
    {
        public Plat Состояние;
        public Кредит() : base()
        {
            Состояние = Plat.Некредитоспособный;
        }
        public Кредит(int pCost, Valuta pV, Srochnost pS, DateTime pD, Plat pP) : base(pCost, pV, pS, pD)
        {
            Состояние = pP;
        }
            public override string Sum
        {
            get
            {
                if (Convert.ToBoolean(Состояние == Plat.Кредитоспособный)) { return $"Кредитоспособен, сумма: {cost}"; }
                else { return "Некредитоспособен, в кредите отказано"; }
            }
        }

        public override void Col() 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Col();
        }
    }
}
    
       


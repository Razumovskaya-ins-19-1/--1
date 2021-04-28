using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.IO;

namespace LogicTier
{
    public class ТурПоездки
    {
        private Поездка _поездка;
        public ТурПоездки(Поездка p)
        {
            _поездка = p;
        }
        public string ТранспортПоездки
        {
            get { return _поездка.Транспорт; }
            set { _поездка.Транспорт = value; }
        }
        public string ПунктОтправкиПоездки
        {
            get { return _поездка.Пункт_отправки; }
            set { _поездка.Пункт_отправки = value; }
        }
        public string ПунктНазначенияПоездки
        {
            get { return _поездка.Пункт_назначения; }
            set { _поездка.Пункт_назначения = value; }
        }
        public float СтоимостьПоездки
        {
            get { return _поездка.Стоимость; }
            set { _поездка.Стоимость = value; }
        }


        public String ПредставлениеПоездки
        {
            get { return _поездка.Транспорт + " : " + _поездка.Пункт_отправки + " : " + _поездка.Пункт_назначения + " : " + _поездка.Стоимость.ToString("C"); }
        }
    }
    public class Тур
    {
        StreamReader txr = new StreamReader(@"data.txt");
        private List<ТурПоездки> _поездки = new List<ТурПоездки>();
        int s = 0;
        float ss, r = 0;
        public Тур()
        {

            List<Поездка> tmp = Все_поездки.Получить_все_поездки(txr);
            foreach (var t in tmp)
            {
                _поездки.Add(new ТурПоездки(t));
                if (t.Транспорт == "Автобус")
                {
                    s += 1;
                }

            }

             ss = (from p in tmp
                        where p.Транспорт == "Самолёт"
                        select p.Стоимость).Sum();
            r = (from p in tmp
                  where p.Транспорт == "Самолёт"
                  select p.Стоимость).Max();

        }
        public List<ТурПоездки> СписокПоездок
        {
            get { return _поездки; }
        }
        public string НаименованиеТурАгенство
        {
            get { return "Ласточка"; }
        }
        public int КоличествоАвтобусныхРейсов
        {
            get { return s; }
        }
        public float СуммарнаяСтоимостьбилетовНаСамолёт
        {
            get { return ss;  }
        }
        public float СамыйДорогойбилет
        {
            get { return r; }
        }
    }
}

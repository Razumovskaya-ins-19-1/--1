using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__16
{
    class RawDataItem
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public int Kurse { get; set; }
        public int Students { get; set; }
        public int Zadolzh { get; set; }
        public int Sum1
        {
            get { return Students - Zadolzh; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Лабораторная_работа__16
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }
        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private List<Summury2> sumdata1;
        private char devider = '*';
        private DataStorage() {}
        private bool InitData(string datapath)
        {
            rawdata = new List<RawDataItem> ();
            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                string line;
                while ((line=sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Name = items[0].Trim(),
                        Group = items[1].Trim(),
                        Kurse = Convert.ToInt32(items[2].Trim()),
                        Students = Convert.ToInt32(items[3].Trim()),
                        Zadolzh = Convert.ToInt32(items[4].Trim()),
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummury();
                BuildSummory2();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        private void BuildSummury()
        {
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Kurse))
                    tmp[item.Kurse] += item.Zadolzh;
                else
                    tmp[item.Kurse] = item.Zadolzh;
            }
            sumdata = new List<SummaryDataItem>();
            sumdata1 = new List<Summury2>();
            foreach (var item in tmp)
            {
                sumdata.Add(new SummaryDataItem
                {
                    Kurse1 = item.Key,
                    KolZadolzh= item.Value
                }
                    );
            }
        }
        public void BuildSummory2()
        {
            Dictionary<string, int> tmp = new Dictionary<string, int>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                    tmp[item.Group] += item.Sum1;
                else
                    tmp[item.Group] = item.Sum1;
            }
            sumdata1 = new List<Summury2>();
            foreach (var item in tmp)
            {
                sumdata1.Add(new Summury2
                {
                    group = item.Key,
                    sum1 = item.Value
                }
                    );
            }
        }
        public static DataStorage DataCreator (String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else return null;
        }
        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else return null;
        }
        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else return null;
        }

        public List<Summury2> GetSummury2Data()
        {
            if (this.IsReady)
                return sumdata1;
            else return null;
        }
    }

}

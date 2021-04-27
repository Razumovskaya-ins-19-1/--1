using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         DataStorage data;
        private void bntLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                ShowData(openFileDialog1.FileName);
        }
        private void ShowData (string datapath)
        {
           
            try
            {
               data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!!!!");
            }
            dvgRaw.DataSource = data.GetRawData();
            dvgRaw.ReadOnly = true;
            dvgSummary.DataSource = data.GetSummury2Data();
            dvgSummary.ReadOnly = true;
            dvgSummury2.DataSource = data.GetSummury2Data();
            dvgSummury2.ReadOnly = true;
        }
    }
}

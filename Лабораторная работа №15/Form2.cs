using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double perem()
        {

                double X = Convert.ToDouble(textBox9.Text);
                return X;

        }
        public int kol()
        {
                int N = Convert.ToInt32(textBox9.Text);
                return N;
        }
    }
   
}

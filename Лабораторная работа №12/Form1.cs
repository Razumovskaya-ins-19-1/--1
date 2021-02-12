using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            double F, w, t, res;
            F = Convert.ToDouble(textBox1.Text);
            w = e.X;
            textBox2.Text = Convert.ToString(w);
            t = e.Y;
            textBox3.Text = Convert.ToString(t);
            if (Math.Cos(w + Math.E) == 0 | t==0)
                textBox4.Text = "Error";
            else
            {
                res = Math.Pow(F, Math.Abs(Math.E)) / Math.Cos(w + Math.E) - Math.E + Math.Abs(Math.Sin(w / t)) / (25 + Math.Sqrt(Math.Abs(Math.E)));
                textBox4.Text = Convert.ToString(res);
                Text = Convert.ToString(res);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}

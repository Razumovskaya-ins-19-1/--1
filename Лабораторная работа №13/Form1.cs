using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double p, b, c, h=0;
            int R, N;
            p = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox4.Text);
            c = Convert.ToDouble(textBox5.Text);
            R = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            N = Convert.ToInt32(listBox1.SelectedItem.ToString());
            if ((c == 0 & radioButton2.Checked == true) | (radioButton1.Checked==false & radioButton2.Checked==false))
            {
                textBox1.Text = "Ошибка!!!!";
            }  
            else
            {
                if (radioButton1.Checked)
                {
                    int t = 1;
                    for (int i = 1; i <= N; i++)
                    {
                        t *= i + 1;
                        if (i % 2 != 0)
                            h += -(1 + i * 2) * Math.Pow(p, i + 1) / t;
                        else
                            h += (1 + i * 2) * Math.Pow(p, i + 1) / t;
                    }
                }
                else
                {
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= R; j++)
                        {
                            h += (i * i + b) / (Math.Pow(c, i) * Math.Pow(i + 1, 3));
                        }
                    }
                }
                textBox1.Text = h.ToString();
            }
            /* Form F2 = new Form();
             F2.Text = h.ToString();
             F2.Show();*/
            MessageBox.Show(textBox1.Text);
        }
    }
}

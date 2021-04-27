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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = panel1.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = textBox1.Font;
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
                textBox1.ForeColor = dlg.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = " Документы (*.txt) | *.txt | Ворд (*.docx) | *.docx";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор файла";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите папку для демонстрации работы диалогового окна";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dlg.SelectedPath;
            }
        }

        // Индивидуальное задание
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            if (F2.ShowDialog()==DialogResult.OK)
            {
                double X = F2.perem();
                int N = F2.kol();
                double h =0;
                for  (int i=0; i<N; i++)
                {
                    if (i % 2 == 0)
                        h += Math.Pow(X, (i + 1) * 2) / ((i + i + 1) * (i + i + 3));
                    else
                        h -= Math.Sin(Math.Pow(X, i + i + 2)) / ((i + i + 1) * (i + i + 3));
                }
                MessageBox.Show( h.ToString(), "Ответ", MessageBoxButtons.OK);
            }

        }
    }
}

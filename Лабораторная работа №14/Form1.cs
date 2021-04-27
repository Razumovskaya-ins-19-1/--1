using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__14
{
    public partial class Form1 : Form
    {
        DateTimeFormat dtFormat = DateTimeFormat.ShowDate;
        ToolStripMenuItem currentCheckedItem;



        public Form1()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        //Таймер
        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowDate)
                info = DateTime.Now.ToString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }
        // Дата
        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }
        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string g = "белый";

        var sss = (ToolStripComboBox)sender;

        if (sss.Name == "toolStripComboBox1")
        {
            g = toolStripComboBox1.Text;
        } else if (sss.Name == "toolStripComboBox3") // 
        {
            g = contextMenuStrip1.Text;
        }

        switch (g)
        {
            case "белый":; BackColor = Color.White; break;
            case "красный":; BackColor = Color.Red; break;
            case "чёрный":; BackColor = Color.Black; break;
            case "синий":; BackColor = Color.Blue; break;
            case "жёлтый":; BackColor = Color.Yellow; break;
            default: BackColor = Color.BlanchedAlmond; break;
        }

    }



    private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            BackColor = Color.FromArgb(
                Convert.ToInt32(toolStripTextBox1.Text),
                Convert.ToInt32(toolStripTextBox2.Text),
                Convert.ToInt32(toolStripTextBox3.Text));
        }
        catch
        {
            MessageBox.Show("Необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        toolStripComboBox1_SelectedIndexChanged(sender, e);
    }
    public enum DateTimeFormat
    {
        ShowTime,
        ShowDate
    }

    private int toolStripTextBox7_TextChanged(object sender, EventArgs e)
    {
        string l;
        int j;
        l = toolStripTextBox7.Text;
        j = Convert.ToInt32(l);
        return j;
    }

    private int toolStripTextBox8_TextChanged(object sender, EventArgs e)
    {
        string l;
        int j;
        l = toolStripTextBox7.Text;
        j = Convert.ToInt32(l);
        return j;
    }

    private int toolStripTextBox9_TextChanged(object sender, EventArgs e)
    {
        string l;
        int j;
        l = toolStripTextBox7.Text;
        j = Convert.ToInt32(l);
        return j;
    }

    private int toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string l = toolStripComboBox2.Text;
        int j;
        j = Convert.ToInt32(l);
        return j;
    }





    private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
    {
        double x = Convert.ToSingle(toolStripTextBox7.Text);
        double y = Convert.ToSingle(toolStripTextBox8.Text);
        double z = Convert.ToSingle(toolStripTextBox9.Text);
        int a = Convert.ToInt32(toolStripComboBox2.Text);
        int b = Convert.ToInt32(toolStripComboBox4.Text);
        double s;
        if (a * x > 0)
        {
            s = Math.Log10(a * x) + Math.Sin(z) + Math.Cos(y);
            Text = Convert.ToString(s);
        }
        else
        {
            MessageBox.Show("Ошибка! \n Под знаком логарифма должно быть положительное число");
            Text = "Ошибка! \n Под знаком логарифма должно быть положительное число";
        }
    }
    private void toolStripMenuItem2_Click_12(object sender, EventArgs e)
    {
        double x = Convert.ToSingle(toolStripTextBox10.Text);
        double y = Convert.ToSingle(toolStripTextBox11.Text);
        double z = Convert.ToSingle(toolStripTextBox12.Text);
        int a = Convert.ToInt32(toolStripComboBox5.Text);
        int b = Convert.ToInt32(toolStripComboBox6.Text);
        double s;
        if (a * x > 0)
        {
            s = Math.Log10(a * x) + Math.Sin(z) + Math.Cos(y);
            Text = Convert.ToString(s);
        }
        else
        {
            MessageBox.Show("Ошибка! \n Под знаком логарифма должно быть положительное число");
            Text = "Ошибка! \n Под знаком логарифма должно быть положительное число";
        }
    }

    // Задание 2
    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        double m;
        toolStripStatusLabelState.Text = $"Координаты курсора: {e.X} {e.Y}";

        if (zToolStripMenuItem.Checked == true)
        {
            if (e.X != e.Y & e.X >= 0)
            {
                m = (e.Y - Math.Sqrt(e.X)) / Math.Abs(e.X - e.Y);
                toolStripStatusLabel2.Text = $"Ответ: {m}";
            }
            else toolStripStatusLabel2.Text = "Ошибка";
        }
        if (fToolStripMenuItem.Checked == true)
        {
            if (e.X >= 0 & e.Y >= 0)
            {
                m = Math.Sqrt(Math.Abs(Math.Sqrt(e.X) - Math.Sqrt(e.Y)));
                toolStripStatusLabel2.Text = $"Ответ: {m}";
            }
            else toolStripStatusLabel2.Text = "Ошибка";
        }
        if (sToolStripMenuItem.Checked == true)
        {

            m = Math.Cos(e.X * e.X) + Math.Pow(Math.Sin(e.Y), 2);
            toolStripStatusLabel2.Text = $"Ответ: {m}";
        }
    }

    private void zToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        var st = (ToolStripMenuItem)sender;

        if (st == zToolStripMenuItem)
        {
           fToolStripMenuItem.Checked = false;
           sToolStripMenuItem.Checked = false;
           
        }
        if (st == fToolStripMenuItem)
        {
          zToolStripMenuItem.Checked = false;
          sToolStripMenuItem.Checked = false;
            
        }
        if (st == sToolStripMenuItem)
        {
          fToolStripMenuItem.Checked = false;
          zToolStripMenuItem.Checked = false;

        }
    }
}
    
}

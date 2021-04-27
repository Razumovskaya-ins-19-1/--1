using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__17
{
    public partial class Form1 : Form
    {
        Color col1 = Color.Red;
        Color col2 = Color.Green;
        Brush active = Brushes.Red;
        Region regResult1 = new Region();
        Region regResult2 = new Region();
        Region up3 = new Region();
        Region do3 = new Region();
        Region lef3 = new Region();
        Region rig3 = new Region();
        Region ok3 = new Region();
        Font f = new Font(FontFamily.GenericSansSerif, 30);
        StringFormat str = new StringFormat();
            

        private Point location = new Point(100, 90);
        public int R = 150;
        Pen pen1 = new Pen(Brushes.Black, 3);
        Pen pen = new Pen(Brushes.Red, 5);
      
        // Point[] p = new[] { new Point(250, 240), new Point (325, 240), new Point (250 + Convert.ToInt32(Math.Cos(Math.Atan(0.5)) * 150 * Math.Cos(Math.Atan(0.5))), 240 - Convert.ToInt32(Math.Sin(Math.Atan(0.5))*150*Math.Cos(Math.Atan(0.5))))};



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            //gr.FillPie(Brushes.Green, location.X, location.Y, R * 2, R * 2, Convert.ToSingle(Math.Atan(-0.5) * 180 / Math.PI), -90 - Convert.ToSingle(Math.Atan(-0.5) * 180 / Math.PI));
            //gr.FillEllipse(SystemBrushes.Control, R + location.X, R / 2 + location.Y, R, R);

            //gr.FillPolygon(Brushes.Green, p);
            //gr.FillPie(Brushes.Green, R + location.X, R / 2 + location.Y, R, R, 0, Convert.ToSingle(Math.Atan(-0.5) * 360 / Math.PI)); 
            //gr.FillPie (SystemBrushes.Control, location.X + R / 2, location.Y + R / 2, R, R, 0, -90);

            Rectangle up2 = new Rectangle(210, 50, 50, 50);
            Rectangle do2 = new Rectangle(210, 385, 50, 50);
            Rectangle lef2 = new Rectangle(60, 200, 50, 50);
            Rectangle rig2 = new Rectangle(400, 200, 50, 50);
            Rectangle x2 = new Rectangle(460, 200, 50, 50);
            Rectangle y2 = new Rectangle(210, 0, 50, 50);
            Rectangle ok = new Rectangle(250, 240, 50, 50);

            GraphicsPath up1 = new GraphicsPath();
            GraphicsPath do1 = new GraphicsPath();
            GraphicsPath lef = new GraphicsPath();
            GraphicsPath rig = new GraphicsPath();
            GraphicsPath x1 = new GraphicsPath();
            GraphicsPath y1 = new GraphicsPath();
            GraphicsPath ok0 = new GraphicsPath();

            up1.AddString("2", FontFamily.GenericSansSerif, 50, 50, up2, str);
            do1.AddString("2", FontFamily.GenericSansSerif, 50, 50, do2, str);
            lef.AddString("2", FontFamily.GenericSansSerif, 50, 50, lef2, str);
            rig.AddString("2", FontFamily.GenericSansSerif, 50, 50, rig2, str);
            x1.AddString("2", FontFamily.GenericSansSerif, 50, 50, x2, str);
            y1.AddString("2", FontFamily.GenericSansSerif, 50, 50, y2, str);
            ok0.AddString("2", FontFamily.GenericSansSerif, 50, 50, ok, str);

            Region up3 = new Region(up1);
            Region do3 = new Region(do1);
            Region lef3 = new Region(lef);
            Region rig3 = new Region(rig);
            Region x3 = new Region(x1);
            Region y3 = new Region(y1);
            Region ok3 = new Region(ok0);


            Rectangle el1 = new Rectangle(location.X, location.Y, R * 2, R * 2);
            GraphicsPath elipse1 = new GraphicsPath();
            elipse1.AddEllipse(el1);
            Rectangle el2 = new Rectangle(R / 2 + location.X, R / 2 + location.Y, R, R);
            GraphicsPath elipse2 = new GraphicsPath();
            elipse2.AddEllipse(el2);
            Rectangle el3 = new Rectangle(R + location.X, R / 2 + location.Y, R, R);
            GraphicsPath elipse3 = new GraphicsPath();
            elipse3.AddEllipse(el3);
            GraphicsPath line = new GraphicsPath();
            line.AddLine(location.X + R - 250, location.Y + R + 250 / 2, location.X + 2 * R + 250, location.Y + R / 2 - 250 / 2);

            Rectangle sector1 = new Rectangle(location.X + R, location.Y, R, R);
            GraphicsPath sect1 = new GraphicsPath();
            sect1.AddPie(el1, Convert.ToSingle(Math.Atan(-0.5) * 180 / Math.PI), -90 - Convert.ToSingle(Math.Atan(-0.5) * 180 / Math.PI));
            GraphicsPath sect2 = new GraphicsPath();
            sect2.AddPie(el1, 0, Convert.ToSingle(Math.Atan(-0.5) * 180 / Math.PI));

            gr.DrawLine(pen1, 0, R + location.Y, 500, R + location.Y);
            gr.DrawLine(pen1, R + location.X, 0, R + location.X, 500);
            gr.DrawEllipse(pen, el1);
            gr.DrawEllipse(new Pen(Brushes.Blue, 5), el2);
            gr.DrawEllipse(new Pen(Brushes.Blue, 5), el3);
            gr.DrawLine(pen1, location.X + R - 250, location.Y + R + 250 / 2, location.X + 2 * R + 250, location.Y + R / 2 - 250 / 2);
            gr.DrawString("2", f, Brushes.Black, up2);
            gr.DrawString("2", f, Brushes.Black, do2);
            gr.DrawString("2", f, Brushes.Black, lef2);
            gr.DrawString("2", f, Brushes.Black, rig2);
            gr.DrawString("x", f, Brushes.Black, x2);
            gr.DrawString("y", f, Brushes.Black, y2);
            gr.DrawString("0", f, Brushes.Black, ok);

            Region regel1 = new Region(elipse1);
            Region regel2 = new Region(elipse2);
            Region regel3 = new Region(elipse3);
            regResult1 = new Region(sect1);
            regResult2 = new Region(sect2);
            regResult1.Exclude(elipse3);
            regResult1.Exclude(elipse2);
            regResult2.Intersect(elipse3);
            regResult2.Exclude(elipse2);

            gr.FillRegion(active, regResult1);
            gr.FillRegion(active, regResult2);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;

            Brush old = new SolidBrush(col1);
            if (regResult1.IsVisible(X, Y) | regResult2.IsVisible(X, Y))
            {
                active = new SolidBrush(col2);
            }
            else
            {
                active = new SolidBrush(col1);
            }
            if (old!= active)
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = col1;  
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                col1 = dlg.Color;
                Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = col2;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                col2 = dlg.Color;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            int X = e.X, Y = e.Y;
            if (up3.IsVisible(X, Y))
            {

            }
        }
    }
}

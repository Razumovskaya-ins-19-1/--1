using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Лабораторная_работа__20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding b = new Binding();
            b.Source = sl;
            b.Path = new PropertyPath("Value");


            PB.SetBinding(ProgressBar.ValueProperty, b);
        }

        private void PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Brush emotion = Brushes.Blue;
            string stylename = "sad";
            if (sl.Value <= 20)
            {
                emotion = Brushes.Blue;
                stylename = "sad";
            }
            if ((sl.Value <= 40) & (sl.Value >20))
            {
                emotion= Brushes.Green;
                stylename = "fastid";
            }
            if ((sl.Value <= 60) & (sl.Value >40))
            {
                emotion= Brushes.Violet;
                stylename = "fear";
            }
            if ((sl.Value <= 80) & (sl.Value > 60))
            {
                emotion = Brushes.Red;
                stylename = "angry";
            }
            if ((sl.Value <= 100) & (sl.Value > 80))
            {
                emotion = Brushes.Yellow;
                stylename = "happy";
            }
            PB.Foreground = emotion;
            rect.Fill = (ImageBrush)this.FindResource(stylename);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        //private void bNormal_Click(object sender, RoutedEventArgs e)
        //{
        //    sldSourse.Value = 30;
        //}

        //private void bBig_Click(object sender, RoutedEventArgs e)
        //{
        //    txtTarget.FontSize = 60;
        //}
    }
}

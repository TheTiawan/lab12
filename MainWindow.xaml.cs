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

namespace lab12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).\nСтороны прямоугольника параллельны осям координат.\nНайти периметр и площадь данного прямоугольника.\nДан размер файла в байтах.\nИспользуя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл (1 килобайт = 1024 байта).");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kilobytes.Text = (Convert.ToInt32(bytes.Text) / 1024).ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные");
            }
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(x2.Text) - Convert.ToInt32(x1.Text);
                int y = Convert.ToInt32(y2.Text) - Convert.ToInt32(y1.Text);
                perimeter.Text = ((x + y) * 2).ToString();
                square.Text = (x * y).ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные");
            }
        }

        private void Clear1_Click(object sender, RoutedEventArgs e)
        {
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
        }

        private void Clear2_Click(object sender, RoutedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void Clear3_Click(object sender, RoutedEventArgs e)
        {
            bytes.Clear();
        }

        private void Clear4_Click(object sender, RoutedEventArgs e)
        {
            kilobytes.Clear();
        }

        private void x1tc(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void y1tc(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void x2tc(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void y2tc(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void bytestc(object sender, TextChangedEventArgs e)
        {
            kilobytes.Clear();
        }
    }
}

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

namespace WpfApp1
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, h, x = 0, s, X;
            bool k1, k2, k3;
            k1 = double.TryParse(a1.Text, out a);
            if (!k1)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            k2 = double.TryParse(b1.Text, out b);
            if (!k2)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            k3 = double.TryParse(c1.Text, out h);
            if (!k3)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            for (x = a; x < b + h; x += h)
            {
                X = (x - Math.Log10(2 * x)) / (3 * x + 1);
                SS.Items.Add($"x = {x:F3}  y = {X:F3}");
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

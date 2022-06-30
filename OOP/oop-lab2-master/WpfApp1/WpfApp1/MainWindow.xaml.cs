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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double S, S2, rez, x, y, z, S1, S3, E;
            bool k1, k2, k3, k4;
            k1 = double.TryParse(A.Text,out x);
            if (!k1)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            k2 = double.TryParse(B.Text, out y);
            if (!k2)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            k3 = double.TryParse(C.Text, out z);
            if (!k3)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            k4 = double.TryParse(D.Text, out E);
            if (!k4)
            {
                MessageBox.Show("Помилка введення значення e!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if ((Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25))) < 0)
            {
                MessageBox.Show("Помилка введення значення y та х!!!\nПри використанні данних значень у та х функція Sqrt буде дорівнювати від'ємному зн. ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (E < 0)
            {
                MessageBox.Show("Помилка введення значення e!!\nПри використанні данних значень e функція Sqrt буде дорівнювати від'ємному зн. ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            S = Math.Pow(2, -x);
            S1 = Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25));
            S2 = Math.Pow(Math.Pow(E, (x - 1) / Math.Sin(z)), 1.0 / 3.0);
            S3 = S * S1 * S2;
            G.Text = S3.ToString("F2");

        }
    }
}

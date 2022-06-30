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

namespace WpfApp2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BT_Click(object sender, RoutedEventArgs e)
        {
            l.Visibility = Visibility.Visible;

            l1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Visible;


            xx.Visibility = Visibility.Visible;
            x11.Visibility = Visibility.Visible;
            x22.Visibility = Visibility.Visible;
            double a, b, c;
            double D, x1, x2;
            bool ok1, ok2, ok3;
            ok1 = double.TryParse(a1.Text, out a);
            if (!ok1)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (a == 0)
            {
                MessageBox.Show("При значенні а ='0', рівняння не є квадратним", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            ok2 = double.TryParse(b1.Text, out b);
            if (!ok2)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok3 = double.TryParse(c1.Text, out c);
            if (!ok3)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            D = (Math.Pow(b, 2.0)) - 4 * a * c;
            if (D == 0)
            {
                l1.Visibility = Visibility.Collapsed;
                l2.Visibility = Visibility.Collapsed;
                x11.Visibility = Visibility.Collapsed;
                x22.Visibility = Visibility.Collapsed;
                x1 = -b / (2 * a);
                xx.Text = x1.ToString("F3");

            }
            if (D < 0)
            {
                l1.Visibility = Visibility.Collapsed;
                l2.Visibility = Visibility.Collapsed;
                x11.Visibility = Visibility.Collapsed;
                x22.Visibility = Visibility.Collapsed;
                xx.Visibility = Visibility.Collapsed;
                l.Visibility = Visibility.Collapsed;
                MessageBox.Show("Рівняння не має розв'язків!!!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (D > 0)
            {
                x11.Visibility = Visibility.Visible;
                xx.Visibility = Visibility.Collapsed;
                x22.Visibility = Visibility.Visible;
                l1.Visibility = Visibility.Visible;
                l.Visibility = Visibility.Collapsed;

                l2.Visibility = Visibility.Visible;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x11.Text = x1.ToString("F3");
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                x22.Text = x2.ToString("F3");
            }

        }
    }
}

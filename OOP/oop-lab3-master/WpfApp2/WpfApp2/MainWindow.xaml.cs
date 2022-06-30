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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            bool k1;
            k1 = double.TryParse(a1.Text, out a);
            if (!k1)
            {
                MessageBox.Show("Помилка введення числа!", "Сповіщення", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (check.IsChecked == true)
            {
                if (a % 2 == 0)
                {
                    MessageBox.Show("Число парне!", "Сповіщення", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Число не парне!", "Сповіщення", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            if (a > 1)//просте число-натуральне та відмінне від 1;
            {
                if (a == 2) //встановлюємо спеціальну умову для 2;
                {

                    picture2.Visibility = Visibility.Visible;

                }
                for (int i = 2; i < a; i++)
                    if (a % i == 0) // якщо n ділиться без залишку на і то число не просте;
                    {

                        picture.Visibility = Visibility.Visible;
                        picture2.Visibility = Visibility.Hidden;
                        break;
                    }
                    // якщо програма дійшла до цього етапу то число- просте;
                    else
                    {
                        
                       
                        picture2.Visibility = Visibility.Visible;
                        picture.Visibility = Visibility.Hidden;
                    }

            }


        }

    }
}

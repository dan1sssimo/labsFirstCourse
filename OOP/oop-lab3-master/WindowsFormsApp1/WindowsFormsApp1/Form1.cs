using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,c;
            bool k1;
            k1 = double.TryParse(textBox1.Text, out a);
        
            if (!k1)
            {
                MessageBox.Show("!Помилка введення числа !", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            b = Math.Sqrt(a);
            if(checkBox1.Checked==true)
            {
                if (a%2==0)
                {
                    MessageBox.Show("Число парне!!!", "Сповіщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Число не парне!!!", "Сповіщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                           
            }
            if (a > 1)//просте число-натуральне та відмінне від 1;
            {
                if (a == 2) //встановлюємо спеціальну умову для 2;
                {
                    pictureBox1.ImageLocation = @"C:\Users\danil\OneDrive\Рабочий стол\grean.png.png";//звертаємося до розташування зображення на диску;
                   
                }
               for(int i=2;i<a ;i++ )
                if(a%i==0)
                    {
                        pictureBox1.ImageLocation = @"C:\Users\danil\source\repos\WindowsFormsApp3\WindowsFormsApp1\WindowsFormsApp1\Resources\червоний круг.png";
                        break;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = @"C:\Users\danil\OneDrive\Рабочий стол\grean.png.png";
                    }
                
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

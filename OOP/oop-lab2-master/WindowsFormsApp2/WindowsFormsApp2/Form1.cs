using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S, S2, rez, x, y, z, S1, S3,E;
            bool k1,k2,k3,k4;
            k1 = double.TryParse(textBox1.Text, out x);
            if (!k1)
            {
                MessageBox.Show("!Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox5.Clear();
                return;
            }
            k2 = double.TryParse(textBox2.Text, out y);
            if (!k2)
            {
                MessageBox.Show("!!Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox5.Clear();
                return;
            }
            k3 = double.TryParse(textBox3.Text, out z);
            if (!k3)
            {
                MessageBox.Show("!!!Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                textBox5.Clear();
                return;
            }
            k4 = double.TryParse(textBox3.Text, out E);
            if (!k4)
            {
                MessageBox.Show("!!!Помилка введення значення e!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
                textBox5.Clear();
                return;
            }
          
            if ((Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25)))<0)
            {
                MessageBox.Show("Помилка введення значення y та х!!!\nПри використанні данних значень у та х функція Sqrt буде дорівнювати від'ємному зн. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (E < 0)
            {
                MessageBox.Show("Помилка введення значення e!!\nПри використанні данних значень e функція Sqrt буде дорівнювати від'ємному зн. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            S = Math.Pow(2, -x);
            S1 = Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25));
            S2 = Math.Pow(Math.Pow(E, (x - 1) / Math.Sin(z)), 1.0 / 3.0);
            S3 = S * S1 * S2;
            textBox5.Text = S3.ToString("F2");
        }
    }
}

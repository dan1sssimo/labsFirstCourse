using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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



        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h, x = 0, s,X;
            bool k1, k2, k3;
            k1 = double.TryParse(textBox1.Text, out a);
            if (!k1)
            {
                MessageBox.Show("!Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            k2 = double.TryParse(textBox2.Text, out b);
            if (!k2)
            {
                MessageBox.Show("!!Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            k3 = double.TryParse(textBox3.Text, out h);
            if (!k3)
            {
                MessageBox.Show("!!!Помилка введення значення h!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (x = a; x < b + h; x += h)
            {
                X = (x - Math.Log10(2 * x)) / (3*x+1);
                listBox1.Items.Add($"x = {x:F3}  y = {X:F3}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

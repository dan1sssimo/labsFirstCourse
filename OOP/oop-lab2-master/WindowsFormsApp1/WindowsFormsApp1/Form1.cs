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
           
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            label4.Visible = true;
            double a, b, c; double D, x1, x2;
            bool ok1, ok2, ok3;
            ok1 = double.TryParse(textBox1.Text, out a);
            if (!ok1)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                return;
            }
            if (a == 0)
            {
                MessageBox.Show("При значенні а ='0', рівняння не є квадратним", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ok2 = double.TryParse(textBox2.Text, out b);
            if (!ok2)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                return;
            }
            ok3 = double.TryParse(textBox3.Text, out c);
            if (!ok3)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                return;
            }
            D = (Math.Pow(b, 2.0)) - 4 * a * c;
            if (D == 0)
            {
                x1 = -b / (2 * a);
                textBox4.Text = x1.ToString("F3");         
                label4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            if (D < 0)
            {
                textBox4.Visible = false;
                label6.Visible = false;
                label6.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                label4.Visible = false;
                label5.Visible = false;
                MessageBox.Show("Рівняння не має розв'язків!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (D > 0)
            {
                
                label6.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;

                label4.Visible = true;
                label5.Visible = true;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                textBox5.Text = x1.ToString("F3");
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox6.Text = x2.ToString("F3");
            }

        }
    }
}

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
            {
                InitializeComponent();
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;

            }
        }
        double[] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok;
            int N, Z;
            double rez = 0, tmp;
            do
            {
                ok = int.TryParse(numericUpDownChuslo.Text, out N);
                if (!ok)
                    MessageBox.Show("Помилка введення значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (!ok);
            mas = new double[N];
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = N;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(-8541, 3531) / 1000.0;
                dataGridViewArray[i, 0].Value = mas[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N;
            double rez = 0, tmp;
            N = int.Parse(numericUpDownChuslo.Text); ;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 3 != 0)
                {
                    rez += mas[i];
                }
            }
            textBox1.Text = rez.ToString();
            for (int i = 1; i < N; i++)
            {
                tmp = mas[i];
                for (int j = i - 1; j >= 0 && mas[j] > tmp; j--)
                {
                    mas[j + 1] = mas[j];
                    mas[j] = tmp;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewArray2.RowCount = 1;
                dataGridViewArray2.ColumnCount = N;
                dataGridViewArray2.Columns[i].HeaderText = i.ToString();
                dataGridViewArray2[i, 0].Value = mas[i];

            }

        }
    }
}

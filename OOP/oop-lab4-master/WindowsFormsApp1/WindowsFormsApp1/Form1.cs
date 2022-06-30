using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static System.Console;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        double[,] arr = new double[100, 100];
        public Form1()
        {

            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool ok;
            int N, M;
            do
            {
                ok = int.TryParse(numericUpDownRyadki.Text, out N);
                if (!ok)
                    MessageBox.Show("Помилка введення значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (!ok);
            do
            {
                ok = int.TryParse(numericUpDownStovpzi.Text, out M);
                if (!ok)
                    MessageBox.Show("Помилка введення значення!", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (!ok);
            arr = new double[N, M];
            Random rnd = new Random();
            dataGridViewMatrix.RowCount = N;
            dataGridViewMatrix.ColumnCount = M;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = rnd.Next(-108005, 5103) / 1000.0;
                    dataGridViewMatrix[j, i].Value = arr[i, j];
                    dataGridViewMatrix.Columns[j].HeaderText = j.ToString();
                    dataGridViewMatrix.Columns[j].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
                    dataGridViewMatrix.Rows[i].HeaderCell.Value = i.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N, M; 
            int count = 0;
            double tmp;
            N = int.Parse(numericUpDownRyadki.Text);
            M = int.Parse(numericUpDownStovpzi.Text);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            textBox1.Text = (arr.GetLength(0) - count).ToString();
            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < M; j++)
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[M - i - 1, j];
                    arr[M - i - 1, j] = tmp;
                }
            dataGridMatrix2.RowCount = N;
            dataGridMatrix2.ColumnCount = M;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    dataGridMatrix2[j, i].Value = arr[i, j];
                    dataGridMatrix2.Columns[j].HeaderText = j.ToString();
                    dataGridMatrix2.Columns[j].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
                    dataGridMatrix2.Rows[i].HeaderCell.Value = i.ToString();
                }
            }
        }
    }
    }

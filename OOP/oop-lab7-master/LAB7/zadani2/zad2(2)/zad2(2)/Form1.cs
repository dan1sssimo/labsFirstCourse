using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rezzz.Text = "";
            int koef, gid,dni,cheli;
            bool x,y;
            if (rb2.Checked == true)
                if (cb1.SelectedIndex == 0)
                    koef = 100;
                else
                    if (cb1.SelectedIndex == 1)
                    koef = 160;
                else
                    if (cb1.SelectedIndex == 2)
                    koef = 120;
                else
                    koef = 20;
            else
                if (cb1.SelectedIndex == 0)
                koef = 150;
            else
                if (cb1.SelectedIndex == 1)
                koef = 200;
            else
                if (cb1.SelectedIndex == 2)
                koef = 180;
            else
                koef = 30;
            x = int.TryParse(tb1.Text, out dni);
            if(!x)
            {
                MessageBox.Show("Помилка введення значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                tb1.Clear();
                return;
            }
            y = int.TryParse(tb2.Text, out cheli);
            if (!y)
            {
                MessageBox.Show("Помилка введення значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb1.Clear();
                return;
            }
            if (check1.Checked == true)
                gid = 50;
            else
                gid = 0;
            rezzz.Text=(koef*dni*cheli+(gid*dni)).ToString("F0");
            label7.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

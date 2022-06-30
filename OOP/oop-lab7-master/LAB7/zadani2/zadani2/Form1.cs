using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadani2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezz.Text = "";
            double width, height, windsill,koef;
            bool x, y = false;
            if (check1.Checked == true)
                windsill = 35;
            else
                windsill = 0;
            if (rb1.Checked == true)
             
                if (cb1.SelectedIndex == 0)
                    koef = 0.25;
                else
                if (cb1.SelectedIndex == 1)
                    koef = 0.05;
                else
                    koef = 0.15;
            else
                if (cb1.SelectedIndex == 0)
                    koef = 0.3;
                else
                if (cb1.SelectedIndex == 1)
                    koef = 0.1;
                else
                    koef = 0.2;
            x = double.TryParse(tb1.Text, out width);
            if (!x)
            {
                MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb1.Clear();
                return;
            }
            y= double.TryParse(tb2.Text, out height);
            if (!y)
            {
                MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb2.Clear();
                return;
            }
            if(x && y)
            {
                rezz.Text = (width * height * koef + windsill).ToString("F2");
            }
        }
    }
}

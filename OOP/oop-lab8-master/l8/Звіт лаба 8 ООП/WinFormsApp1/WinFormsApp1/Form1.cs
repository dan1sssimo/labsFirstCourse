using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        protected Graphics g;
        protected Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void droW_Click(object sender, EventArgs e)
        {
            Mal();
        }

        private void stertu_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }
        private void Mal()
        {
            g = pb1.CreateGraphics();
            Shape[] arr = new Shape[20];
            for (int i = 0; i < 20; i++)
            {
                switch (rnd.Next(6))
                {
                    case 1:
                        arr[0] = new WinFormsLibrary1.Tochka();
                        arr[0].Draw(g);
                        break;
                    case 2:
                        arr[i] = new WinFormsLibrary1.Circle();
                        arr[i].Draw(g);
                        break;
                    case 3:
                        arr[i] = new WinFormsLibrary1.Line();
                        arr[i].Draw(g);
                        break;
                    case 4:
                        arr[i] = new WinFormsLibrary1.Ellipse();
                        arr[i].Draw(g);
                        break;
                    case 5:
                        arr[i] = new WinFormsLibrary1.Pramokut();
                        arr[i].Draw(g);
                        break;
                }
            }
            }
        }
    }


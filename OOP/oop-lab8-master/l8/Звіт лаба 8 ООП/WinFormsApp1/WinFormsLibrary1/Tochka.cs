using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsLibrary1
{
    public class Tochka : Shape
    {
        protected int y1, x1, shuruna;
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Shuruna { get; set; }
        public Tochka(Color color, Color color2, int prozorist, int x1, int y1) : base(color, color2, prozorist)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public Tochka():base()
        {
            x1 = rnd.Next(800);
            y1 = rnd.Next(800);
            shuruna = rnd.Next(6);
        }
        public override void Draw(Graphics g)
        {
            Brush brush=new LinearGradientBrush(new System.Drawing.Rectangle(0,0,800,800),Color.FromArgb(prozorist,color),Color.FromArgb(prozorist,Color2),LinearGradientMode.ForwardDiagonal);
            g.FillEllipse(brush, x1, y1, shuruna, shuruna);
        }
    }
}

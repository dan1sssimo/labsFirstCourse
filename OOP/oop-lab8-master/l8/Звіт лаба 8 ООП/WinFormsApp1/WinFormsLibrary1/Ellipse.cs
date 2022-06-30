using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace WinFormsLibrary1
{
    public class Ellipse:Circle
    {
        protected int rad2;
        public int Rad2 { get; set; }
        public Ellipse() : base()
        {
            rad2 = rnd.Next(250);
        }
        public Ellipse(Color color, Color color2, int prozorist,int x1,int y1,int rad,int rad2) : base(color, color2, prozorist, x1, y1, rad)
        {
            this.rad2 = rad2;
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new LinearGradientBrush(new System.Drawing.Rectangle(0, 0, 800, 800), Color.FromArgb(prozorist, color), Color.FromArgb(prozorist, color2), LinearGradientMode.ForwardDiagonal);
            g.FillEllipse(brush, x1, y1, rad, rad2);
        }
    }
}

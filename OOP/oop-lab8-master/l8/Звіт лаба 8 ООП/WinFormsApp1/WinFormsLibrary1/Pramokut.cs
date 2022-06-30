using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace WinFormsLibrary1
{
    public class Pramokut:Tochka
    {
        protected int vusota;
        public int Vusota { get; set; }
        public Pramokut() : base()
        {
            vusota = rnd.Next(500);
            shuruna = rnd.Next(500);
        }
        public Pramokut(Color color, Color color2, int prozorist, int x1, int y1,int vusota):base(color,color2,prozorist,x1,y1)
        {
            this.vusota = vusota;
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new LinearGradientBrush(new System.Drawing.Rectangle(0, 0, 800, 800), Color.FromArgb(prozorist, color), Color.FromArgb(prozorist, color2), LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(brush, x1, y1, shuruna, vusota);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsLibrary1
{
    public class Line:Tochka
    {
        protected int x2,y2;
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line():base()
        {
            x2 = rnd.Next(800);
            y2 = rnd.Next(400);
            x1 = rnd.Next(800);
            y2 = rnd.Next(400);
        }
        public Line(Color color, Color color2, int prozorist,int x1,int y1,int x2,int y2):base(color,color2,prozorist,x1,y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new LinearGradientBrush(new System.Drawing.Rectangle(0, 0, 800, 800), Color.FromArgb(prozorist, color), Color.FromArgb(prozorist, color2), LinearGradientMode.ForwardDiagonal);
            Pen pen = new Pen(brush, shuruna);
            g.DrawLine(pen, x1, y1, x2, y2);
        }

    }
}

using System;
using System.Drawing;

namespace WinFormsLibrary1
{
    public abstract class Shape //colora
    {
        public static Random rnd = new Random();
        protected static Color color;
        protected static Color color2;
        protected static int prozorist;
        public Color Color
        { set; 
          get;
        }
        public Color Color2
        { set;
          get;
        }
        public int Prozorist
        { set; 
          get;
        }
        public Shape(Color color, Color color2, int prozorist)
        {
            Shape.color2 = color2;
            Shape.color = color;
            Shape.prozorist = prozorist;
        }
        public Shape(Color color, int opacity)
        {
            Shape.color = color;
            Shape.prozorist = opacity;
        }
        public Shape() // kolori rn
        {
            prozorist = rnd.Next(210);
            color = Color.FromArgb(prozorist, rnd.Next(155), rnd.Next(155), rnd.Next(155));
            prozorist = rnd.Next(210);
            color2 = Color.FromArgb(prozorist, rnd.Next(155), rnd.Next(155), rnd.Next(155));
        }
        public Shape(Shape obj)
        {
            Color = obj.Color;
            Color2 = obj.Color2;
            Prozorist = obj.Prozorist;
        }
        public abstract void Draw(Graphics g);
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace Task_2
{
    internal class Circle : IFigure
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int R { get; set; }
        public Pen pen { get; set; }

        public Circle(int x1, int y1, int x2, int y2, Pen pen)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            this.pen = pen;
        }

        public void Draw(Graphics graphics)
        {
            R = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            graphics.DrawEllipse(pen, X1-R, Y1-R, 2*R, 2*R);
        }
    }
}

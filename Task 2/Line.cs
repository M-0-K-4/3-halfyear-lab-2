using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class Line : IFigure
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Pen pen { get; set; }

        public Line(int x1, int y1, int x2, int y2, Pen pen)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            this.pen = pen;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }
}

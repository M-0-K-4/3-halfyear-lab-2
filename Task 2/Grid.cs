using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class Grid : IFigure
    {
        public int Step { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Pen pen { get; set; }

        public Grid(Pen pen, int step, int x1, int y1, int x2, int y2)
        {
            if (step == 0)
                Step = 100;
            else
                Step = step;
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            this.pen = pen;
        }

        public void Draw(Graphics graphics)
        {
            int x = X1;
            while(x + Step <= X2)
            {
                graphics.DrawLine(pen, x, Y1, x, Y2);
                x += Step;
            }
            graphics.DrawLine(pen, X2, Y1, X2, Y2);
            int y = Y1;
            while (y + Step <= Y2)
            {
                graphics.DrawLine(pen, X1, y, X2, y);
                y += Step;
            }
            graphics.DrawLine(pen, X1, Y2, X2, Y2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    enum State
    {
        Default,
        BeginLine,
        EndLine,
        BeginRect,
        EndRect,
        BeginCircle,
        EndCircle,
        BeginGrid,
        EndGrid
    }

    internal class Assistant
    {
        public List<IFigure> Figures { get; set; }
        public State State { get; set; }
        public IFigure CurrentFigure { get; set; }

        public Assistant()
        {
            Figures = new List<IFigure>();
        }

        public void Push()
        {
            Figures.Add(CurrentFigure);
            CurrentFigure = null;
        }

        public void Draw(Graphics graphics)
        {
            foreach (var fig in Figures)
            {
                fig.Draw(graphics);
            }
            if (CurrentFigure != null)
            {
                CurrentFigure.Draw(graphics);
            }
        }
    }
}

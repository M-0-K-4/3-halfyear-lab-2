namespace Task_2
{
    public partial class Form1 : Form
    {
        Assistant assistant = new();
        Pen pen = new(Color.Black, 4);

        public Form1()
        {
            InitializeComponent();
            toolStripTextBox.Enabled = false;
        }

        private void toolStripButton_Line_Click(object sender, EventArgs e)
        {
            assistant.State = State.BeginLine;
        }

        private void toolStripButton_Circle_Click(object sender, EventArgs e)
        {
            assistant.State = State.BeginCircle;
        }

        private void toolStripButton_Rectangle_Click(object sender, EventArgs e)
        {
            assistant.State = State.BeginRect;
        }

        private void toolStripButton_Grid_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox.Text == "Крок сітки, пкс") 
                toolStripTextBox.Text = "";
            toolStripTextBox.Enabled = true;
            assistant.State = State.BeginGrid;
        }

        private void toolStripButton_Color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            toolStripButton_Color.BackColor = colorDialog.Color;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (assistant.State)
            {
                case State.Default:
                    break;
                case State.BeginLine:
                    pen = new(toolStripButton_Color.BackColor, 4);
                    assistant.CurrentFigure = new Line(e.X, e.Y, e.X, e.Y, pen);
                    assistant.State = State.EndLine;
                    break;
                case State.EndLine:
                    var line = assistant.CurrentFigure as Line;
                    line.X2 = e.X;
                    line.Y2 = e.Y;
                    assistant.Push();
                    assistant.State = State.Default;
                    break;
                case State.BeginCircle:
                    pen = new(toolStripButton_Color.BackColor, 4);
                    assistant.CurrentFigure = new Circle(e.X, e.Y, e.X, e.Y, pen);
                    assistant.State = State.EndCircle;
                    break;
                case State.EndCircle:
                    var circle = assistant.CurrentFigure as Circle;
                    circle.X2 = e.X;
                    circle.Y2 = e.Y;
                    assistant.Push();
                    assistant.State = State.Default;
                    break;
                case State.BeginRect:
                    pen = new(toolStripButton_Color.BackColor, 4);
                    assistant.CurrentFigure = new Rectangle(pen, e.X, e.Y, e.X, e.Y);
                    assistant.State = State.EndRect;
                    break;
                case State.EndRect:
                    var rect = assistant.CurrentFigure as Rectangle;
                    rect.X2 = e.X;
                    rect.Y2 = e.Y;
                    assistant.Push();
                    assistant.State = State.Default;
                    break;
                case State.BeginGrid:
                    pen = new(toolStripButton_Color.BackColor, 4);
                    assistant.CurrentFigure = new Grid(pen, int.Parse(toolStripTextBox.Text), e.X, e.Y, e.X, e.Y);
                    assistant.State = State.EndGrid;
                    break;
                case State.EndGrid:
                    var grid = assistant.CurrentFigure as Grid;
                    grid.X2 = e.X;
                    grid.Y2 = e.Y;
                    assistant.Push();
                    assistant.State = State.Default;
                    break;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripCoordinates.Text = $"{e.X} : {e.Y}";

            switch (assistant.State)
            {
                case State.EndLine:
                    var line = assistant.CurrentFigure as Line;
                    line.X2 = e.X;
                    line.Y2 = e.Y;
                    panel.Invalidate();
                    break;
                case State.EndCircle:
                    var circle = assistant.CurrentFigure as Circle;
                    circle.X2 = e.X;
                    circle.Y2 = e.Y;
                    panel.Invalidate();
                    break;
                case State.EndRect:
                    var rect = assistant.CurrentFigure as Rectangle;
                    rect.X2 = e.X;
                    rect.Y2 = e.Y;
                    panel.Invalidate();
                    break;
                case State.EndGrid:
                    var grid = assistant.CurrentFigure as Grid;
                    grid.X2 = e.X;
                    grid.Y2 = e.Y;
                    panel.Invalidate();
                    break;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            assistant.Draw(e.Graphics);
        }
    }
}

using System.Drawing.Drawing2D;

namespace Task_1
{
    public partial class Form1 : Form
    {
        Pen pen = new(Color.DarkSeaGreen, 4);
        Point[] cod = new Point[]
        {
            new Point(122, 42), new Point(202, 42),
            new Point(142,75), new Point(142,130),
            new Point(182,75), new Point(182,130),
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            e.Graphics.DrawLine(pen, cod[0], cod[1]);
            e.Graphics.DrawLine(pen, cod[2], cod[3]);
            e.Graphics.DrawLine(pen, cod[4], cod[5]);
            e.Graphics.DrawArc(pen, 122, 0, 80, 80, 0, 180);

            pen.Dispose();
        }
    }
}

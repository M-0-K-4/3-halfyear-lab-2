namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip = new StatusStrip();
            toolStripCoordinates = new ToolStripStatusLabel();
            panel = new Panel();
            saveFileDialog = new SaveFileDialog();
            toolStrip = new ToolStrip();
            toolStripButton_Line = new ToolStripButton();
            toolStripButton_Circle = new ToolStripButton();
            toolStripButton_Rectangle = new ToolStripButton();
            toolStripButton_Grid = new ToolStripButton();
            toolStripTextBox = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton_Color = new ToolStripButton();
            toolStripLabel_Color = new ToolStripLabel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            colorDialog = new ColorDialog();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripCoordinates });
            statusStrip.Location = new Point(0, 577);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(973, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripCoordinates
            // 
            toolStripCoordinates.Name = "toolStripCoordinates";
            toolStripCoordinates.Size = new Size(39, 17);
            toolStripCoordinates.Text = "Status";
            // 
            // panel
            // 
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 24);
            panel.Name = "panel";
            panel.Size = new Size(973, 553);
            panel.TabIndex = 2;
            panel.Paint += panel_Paint;
            panel.MouseClick += panel_MouseClick;
            panel.MouseMove += panel_MouseMove;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton_Line, toolStripButton_Circle, toolStripButton_Rectangle, toolStripButton_Grid, toolStripTextBox, toolStripSeparator1, toolStripButton_Color, toolStripLabel_Color });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(973, 25);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_Line
            // 
            toolStripButton_Line.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Line.Image = Properties.Resources.line;
            toolStripButton_Line.ImageTransparentColor = Color.Magenta;
            toolStripButton_Line.Name = "toolStripButton_Line";
            toolStripButton_Line.Size = new Size(23, 22);
            toolStripButton_Line.Click += toolStripButton_Line_Click;
            // 
            // toolStripButton_Circle
            // 
            toolStripButton_Circle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Circle.Image = Properties.Resources.circle;
            toolStripButton_Circle.ImageTransparentColor = Color.Magenta;
            toolStripButton_Circle.Name = "toolStripButton_Circle";
            toolStripButton_Circle.Size = new Size(23, 22);
            toolStripButton_Circle.Click += toolStripButton_Circle_Click;
            // 
            // toolStripButton_Rectangle
            // 
            toolStripButton_Rectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Rectangle.Image = Properties.Resources.rectangle;
            toolStripButton_Rectangle.ImageTransparentColor = Color.Magenta;
            toolStripButton_Rectangle.Name = "toolStripButton_Rectangle";
            toolStripButton_Rectangle.Size = new Size(23, 22);
            toolStripButton_Rectangle.Click += toolStripButton_Rectangle_Click;
            // 
            // toolStripButton_Grid
            // 
            toolStripButton_Grid.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Grid.Image = Properties.Resources.grid;
            toolStripButton_Grid.ImageTransparentColor = Color.Magenta;
            toolStripButton_Grid.Name = "toolStripButton_Grid";
            toolStripButton_Grid.Size = new Size(23, 22);
            toolStripButton_Grid.Click += toolStripButton_Grid_Click;
            // 
            // toolStripTextBox
            // 
            toolStripTextBox.Name = "toolStripTextBox";
            toolStripTextBox.Size = new Size(100, 25);
            toolStripTextBox.Text = "Крок сітки, пкс";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton_Color
            // 
            toolStripButton_Color.BackColor = SystemColors.WindowText;
            toolStripButton_Color.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Color.ImageTransparentColor = Color.Magenta;
            toolStripButton_Color.Name = "toolStripButton_Color";
            toolStripButton_Color.Size = new Size(23, 22);
            toolStripButton_Color.Click += toolStripButton_Color_Click;
            // 
            // toolStripLabel_Color
            // 
            toolStripLabel_Color.Name = "toolStripLabel_Color";
            toolStripLabel_Color.Size = new Size(38, 22);
            toolStripLabel_Color.Text = "Колір";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(973, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 599);
            Controls.Add(toolStrip);
            Controls.Add(panel);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private Panel panel;
        private SaveFileDialog saveFileDialog;
        private ToolStripStatusLabel toolStripCoordinates;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton_Line;
        private ToolStripButton toolStripButton_Circle;
        private ToolStripButton toolStripButton_Rectangle;
        private ToolStripButton toolStripButton_Grid;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Color;
        private ToolStripLabel toolStripLabel_Color;
        private ColorDialog colorDialog;
        private ToolStripTextBox toolStripTextBox;
    }
}

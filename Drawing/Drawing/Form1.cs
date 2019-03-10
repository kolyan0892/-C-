using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Color currentColor = Color.Black;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dR = colorDialog1.ShowDialog();
            if (dR == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }
        }

        private void DrawRectangleButton_Click(object sender, EventArgs e)
        {
            Dot rectangle = new Rectangle(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text), Int32.Parse(rectangleTextBox.Text));
            rectangle.Draw(graphics, currentColor);
        }

        private void DrawLineButton_Click(object sender, EventArgs e)
        {
            Dot line = new Line(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text), Int32.Parse(x1TextBox.Text), Int32.Parse(y1TextBox.Text));
            line.Draw(graphics, currentColor);
        }

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            Dot circle = new Circle(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text), Int32.Parse(radiusTextBox.Text));
            circle.Draw(graphics, currentColor);
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            Dot triangle = new Triangle(Int32.Parse(xTextBox.Text), Int32.Parse(yTextBox.Text), Int32.Parse(triangleX1TextBox.Text), Int32.Parse(triangleY1TextBox.Text), Int32.Parse(triangleX2TextBox.Text), Int32.Parse(triangleY2TextBox.Text));
            triangle.Draw(graphics, currentColor);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}

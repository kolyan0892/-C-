using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Rectangle : Dot
    {
        private float WidthHeight { get; set; } = 1;

        public Rectangle(float x, float y, float widthHeight) : base(x, y)
        {
            WidthHeight = widthHeight;
        }

        public override void Draw(Graphics graphics, Color color)
        {
            Pen p = new Pen(color);
            graphics.DrawRectangle(p, X, Y, WidthHeight, WidthHeight);
        }
    }
}

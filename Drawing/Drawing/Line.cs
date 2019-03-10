using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Line : Dot
    {
        private float X1 { get; set; }
        private float Y1 { get; set; }

        public Line(float x, float y, float x1, float y1) : base(x, y)
        {
            X1 = x1;
            Y1 = y1;
        }

        public override void Draw(Graphics graphics, Color color)
        {
            Pen p = new Pen(color);
            graphics.DrawLine(p, X, Y, X1, Y1);
        }
    }
}

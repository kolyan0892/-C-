using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Triangle : Dot
    {
        private float X1 { get; set; }
        private float Y1 { get; set; }
        private float X2 { get; set; }
        private float Y2 { get; set; }

        public Triangle(float x, float y, float x1, float y1, float x2, float y2) : base(x, y)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw(Graphics graphics, Color color)
        {
            Pen p = new Pen(color);
            graphics.DrawLine(p, X, Y, X1, Y1);
            graphics.DrawLine(p, X, Y, X2, Y2);
            graphics.DrawLine(p, X1, Y1, X2, Y2);
        }
    }
}

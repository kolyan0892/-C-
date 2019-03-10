using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Circle : Dot
    {
        private float R { get; set; }

        public Circle(float x, float y, float r) : base(x, y)
        {
            R = r;
        }

        public override void Draw(Graphics graphics, Color color)
        {
            Pen p = new Pen(color);
            graphics.DrawEllipse(p, X - R, Y - R, 2 * R, 2 * R);
        }
    }
}

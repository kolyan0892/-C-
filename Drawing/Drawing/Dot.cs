using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    abstract class Dot
    {
        protected float X { get; set; }
        protected float Y { get; set; }

        private float Width { get; set; } = 1;
        private float Height { get; set; } = 1;

        public Dot(float x, float y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw(Graphics graphics, Color color);
    }
}

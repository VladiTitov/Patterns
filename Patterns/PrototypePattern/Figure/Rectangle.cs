using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Figure
{
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public void GetInfo() => Console.WriteLine($"Прямоугольник длиной {height} и шириной {width}");
    }
}

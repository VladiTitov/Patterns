using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Figure
{
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
        }

        public void GetInfo() => Console.WriteLine($"Круг радиусом {radius}");
    }
}

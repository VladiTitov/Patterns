using PrototypePattern.Figure;
using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(25, 35);
            IFigure cloneFigure = figure.Clone();
            figure.GetInfo();
            cloneFigure.GetInfo();

            figure = new Circle(45);
            cloneFigure = figure.Clone();
            figure.GetInfo();
            cloneFigure.GetInfo();

            Console.ReadLine();
        }
    }
}

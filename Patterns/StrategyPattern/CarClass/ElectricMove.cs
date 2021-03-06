using System;

namespace StrategyPattern.CarClass
{
    class ElectricMove : IMovable
    {
        public void Move() => Console.WriteLine("Перемещение на электричестве");
    }
}

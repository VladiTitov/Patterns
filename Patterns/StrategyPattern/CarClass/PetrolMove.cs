using System;

namespace StrategyPattern.CarClass
{
    class PetrolMove : IMovable
    {
        public void Move() => Console.WriteLine("Перемещается на бензине");
    }
}

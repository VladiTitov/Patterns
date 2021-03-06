using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.MovementBlock
{
    class RunMovement : Movement
    {
        public override void Move() => Console.WriteLine("Бежим");
    }
}

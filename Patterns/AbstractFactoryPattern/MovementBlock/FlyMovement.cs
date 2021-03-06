using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.MovementBlock
{
    class FlyMovement : Movement
    {
        public override void Move() => Console.WriteLine("Летим");
    }
}

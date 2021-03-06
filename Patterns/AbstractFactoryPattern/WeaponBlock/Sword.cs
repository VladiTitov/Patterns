using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.WeaponBlock
{
    class Sword : Weapon
    {
        public override void Hit() => Console.WriteLine("Бьем мечом");
    }
}

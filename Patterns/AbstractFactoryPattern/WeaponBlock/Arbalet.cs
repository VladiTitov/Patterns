using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.WeaponBlock
{
    class Arbalet : Weapon
    {
        public override void Hit() => Console.WriteLine("Стреляем из арбалета");
    }
}

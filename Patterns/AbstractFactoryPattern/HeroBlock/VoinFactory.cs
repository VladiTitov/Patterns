using AbstractFactoryPattern.HeroBlock;
using AbstractFactoryPattern.MovementBlock;
using AbstractFactoryPattern.WeaponBlock;
using System;

namespace AbstractFactoryPattern.Interfaces
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}

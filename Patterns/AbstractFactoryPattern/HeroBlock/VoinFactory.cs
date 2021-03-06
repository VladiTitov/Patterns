using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.MovementBlock;
using AbstractFactoryPattern.WeaponBlock;

namespace AbstractFactoryPattern.HeroBlock
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

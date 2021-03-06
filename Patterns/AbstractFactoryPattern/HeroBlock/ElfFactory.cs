using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.MovementBlock;
using AbstractFactoryPattern.WeaponBlock;


namespace AbstractFactoryPattern.HeroBlock
{
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}

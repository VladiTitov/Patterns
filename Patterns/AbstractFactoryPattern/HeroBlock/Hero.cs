using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.HeroBlock
{
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run() => movement.Move();

        public void Hit() => weapon.Hit();
    }
}

using System;

namespace FactoryMethodPattern.HouseBlock
{
    class WoodHouse : House
    {
        public WoodHouse(string n) : base(n) => Print("Деревянный дом");
    }
}

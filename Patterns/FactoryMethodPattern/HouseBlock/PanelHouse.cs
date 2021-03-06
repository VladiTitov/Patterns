using System;

namespace FactoryMethodPattern.HouseBlock
{
    class PanelHouse : House
    {
        public PanelHouse(string n) : base(n) => Print("Панельный дом"); 
    }
}

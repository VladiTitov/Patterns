using FlyweightPattern.Interfaces;
using System;

namespace FlyweightPattern.Objects
{
    class BrickHouse : House
    {
        public BrickHouse() { stages = 5; }

        public override void Build(double longitude, double latitude) => Console.WriteLine($"Построен кирпичный дом из {stages} этажей; координаты: {longitude} широты и {latitude} долготы");
    }
}

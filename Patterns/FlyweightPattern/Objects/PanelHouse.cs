using FlyweightPattern.Interfaces;
using System;

namespace FlyweightPattern.Objects
{
    class PanelHouse : House
    {
        public PanelHouse() { stages = 16; }

        public override void Build(double longitude, double latitude) => Console.WriteLine($"Построен панельный дом из {stages} этажей; координаты: {latitude} широты и {longitude} долготы");
    }
}

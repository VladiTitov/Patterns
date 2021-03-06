using StatePattern.Objects;
using StatePattern.States;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.ReadLine();
        }
    }
}

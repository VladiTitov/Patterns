using StatePattern.Interfaces;
using StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWaterState();
        }
    }
}

using StatePattern.Interfaces;
using StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water) => Console.WriteLine("Повышаем температуру водяного пара");
    }
}

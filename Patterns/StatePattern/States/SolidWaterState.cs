using StatePattern.Interfaces;
using StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class SolidWaterState : IWaterState
    {
        public void Frost(Water water) => Console.WriteLine("Продолжаем заморозку льда");

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в житкость");
            water.State = new LiquidWaterState();
        }
        
    }
}

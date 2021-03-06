using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Objects
{
    class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState ws) => State = ws;

        public void Heat() => State.Heat(this);

        public void Frost() => State.Frost(this);
    }
}

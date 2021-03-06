using StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Interfaces
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}

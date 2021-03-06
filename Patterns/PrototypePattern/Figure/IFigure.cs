using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Figure
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}

using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Objects
{
    class Driver
    {
        public void Travel(ITransport transport) => transport.Drive();
    }
}

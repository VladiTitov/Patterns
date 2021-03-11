using AdapterPattern.Interfaces;
using AdapterPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapters
{
    class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel c) => camel = c;

        public void Drive() => camel.Move();
    }
}

using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Objects
{
    class Auto : ITransport
    {
        public void Drive() => Console.WriteLine("Машина едет по дороге");
    }
}

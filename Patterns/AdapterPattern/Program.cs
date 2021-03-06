using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using AdapterPattern.Objects;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto auto = new Auto();

            driver.Travel(auto);

            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTransport);

            Console.ReadLine();
        }
    }
}

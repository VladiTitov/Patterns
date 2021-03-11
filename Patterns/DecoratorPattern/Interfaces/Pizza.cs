using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Interfaces
{
    abstract class Pizza
    {
        public string Name { get; protected set; }
        public abstract int GetCost();

        public Pizza(string n) => this.Name = n;
    }
}

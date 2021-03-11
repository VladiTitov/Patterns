using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Pizzas
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца") { }

        public override int GetCost()
        {
            return 8;
        }
    }
}

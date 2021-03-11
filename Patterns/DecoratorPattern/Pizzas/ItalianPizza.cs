using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Pizzas
{
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца") { }

        public override int GetCost()
        {
            return 10;
        }
    }
}

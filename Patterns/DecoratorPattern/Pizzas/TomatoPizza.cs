using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Pizzas
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p) : base($"{p.Name} с томатами", p) { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}

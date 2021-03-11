using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Pizzas
{
    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p) : base($"{p.Name} с сыром", p) { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}

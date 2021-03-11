using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Interfaces
{
    abstract class PizzaDecorator : Pizza
    {
        public Pizza pizza;

        public PizzaDecorator(string n, Pizza pizza) : base(n) => this.pizza = pizza;
    }
}

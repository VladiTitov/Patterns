using InterpreterPattern.Expressions;
using InterpreterPattern.Interfaces;
using InterpreterPattern.Objects;
using System;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            int x = 5;
            int y = 8;
            int z = 2;

            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")
                    ),
                new NumberExpression("z")
                    );
            int result = expression.Interpret(context);
            Console.WriteLine($"результат: {result}");

            Console.ReadLine();
        }
    }
}

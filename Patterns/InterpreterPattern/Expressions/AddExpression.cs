using InterpreterPattern.Interfaces;
using InterpreterPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Expressions
{
    class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        } 

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}

using InterpreterPattern.Interfaces;
using InterpreterPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Expressions
{
    class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }
}

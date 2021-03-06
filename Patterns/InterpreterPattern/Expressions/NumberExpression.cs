using InterpreterPattern.Interfaces;
using InterpreterPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Expressions
{
    class NumberExpression : IExpression
    {
        string name;
        public NumberExpression(string variableName) => name = variableName;

        public int Interpret(Context context)
        {
            return context.GetVariables(name);
        }
    }
}

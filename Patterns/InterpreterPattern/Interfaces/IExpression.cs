using InterpreterPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Interfaces
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}

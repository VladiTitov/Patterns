using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Objects
{
    class Context
    {
        Dictionary<string, int> variables;
        public Context() => variables = new Dictionary<string, int>();

        public int GetVariables(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name)) variables[name] = value;
            else variables.Add(name, value);
        }
    }
}

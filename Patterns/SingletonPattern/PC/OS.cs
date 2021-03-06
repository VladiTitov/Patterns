using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.PC
{
    class OS
    {
        public static OS instance;

        public string Name { get; set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInsance(string name)
        {
            if (instance == null) instance = new OS(name);
            return instance;
        }
    }
}

using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Languages
{
    class CSharpLanguage : ILanguage
    {
        public void Build() => Console.WriteLine("С помощью компилятора Roslyn компилируем исходный код в файл exe");

        public void Execute()
        {
            Console.WriteLine("JIT компилирует программу бинарный код");
            Console.WriteLine("CLR выполняет скомпилированный бинарный код");
        }
    }
}

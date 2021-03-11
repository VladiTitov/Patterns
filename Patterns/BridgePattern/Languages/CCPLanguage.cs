using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Languages
{
    class CCPLanguage : ILanguage
    {
        public void Build() => Console.WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");

        public void Execute() => Console.WriteLine("Запускаем исполняемый файл программы");
    }
}

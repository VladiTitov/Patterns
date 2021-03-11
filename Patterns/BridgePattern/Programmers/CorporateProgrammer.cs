using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Programmers
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang) : base(lang) { }

        public override void EarnMoney() => Console.WriteLine("Получаем в конце месяца зарплату");
    }
}

using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Programmers
{
    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang) { }

        public override void EarnMoney() => Console.WriteLine("Получаем оплату за выполненный заказ");
    }
}

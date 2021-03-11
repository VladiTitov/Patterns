using BridgePattern.Interfaces;
using BridgePattern.Programmers;
using BridgePattern.Languages;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer freelancer = new FreelanceProgrammer(new CCPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interfaces;
using VisitorPattern.Objects;

namespace VisitorPattern.Serialize
{
    class XmlVisitor : IVisitor
    {
        public void VisitCompanyAcc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" +
            "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
            "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }

        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.Name + "</Name>" +
            "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }
    }
}

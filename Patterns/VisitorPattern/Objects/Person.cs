using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Objects
{
    class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor) => visitor.VisitPersonAcc(this);
    }
}

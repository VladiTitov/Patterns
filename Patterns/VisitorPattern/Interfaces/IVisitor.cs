using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Objects;

namespace VisitorPattern.Interfaces
{
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAcc(Company acc);
    }
}

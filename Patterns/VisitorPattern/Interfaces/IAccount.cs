using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Interfaces
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}

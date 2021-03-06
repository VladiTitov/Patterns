using IteratorPattern.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Interfaces
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}

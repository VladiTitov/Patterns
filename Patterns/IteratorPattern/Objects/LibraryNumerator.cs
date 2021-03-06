using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Objects
{
    class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;
        public LibraryNumerator(IBookNumerable e) => aggregate = e;

        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }

    }
}

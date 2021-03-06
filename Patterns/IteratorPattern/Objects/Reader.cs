using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Objects
{
    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext()) Console.WriteLine(iterator.Next().Name);
        }
    }
}

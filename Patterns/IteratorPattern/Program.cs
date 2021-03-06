using IteratorPattern.Objects;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.WriteLine();
        }
    }
}

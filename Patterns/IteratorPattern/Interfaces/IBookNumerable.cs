using IteratorPattern.Objects;

namespace IteratorPattern.Interfaces
{
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}

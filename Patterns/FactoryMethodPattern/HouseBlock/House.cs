using System;

namespace FactoryMethodPattern.HouseBlock
{
    abstract class House
    {
        public string Name { get; set; }

        public House(string n) => Name = n;

        public void Print(string part)
        {
            Console.WriteLine($"{Name} построил - {part}");
        }
    }
}

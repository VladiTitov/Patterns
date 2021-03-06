using FactoryMethodPattern.HouseBlock;

namespace FactoryMethodPattern.DeveloperBlock
{
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string n) => Name = n;
        abstract public House Create();
    }
}

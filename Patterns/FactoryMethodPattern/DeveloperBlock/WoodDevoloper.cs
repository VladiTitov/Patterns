using FactoryMethodPattern.HouseBlock;

namespace FactoryMethodPattern.DeveloperBlock
{
    class WoodDevoloper : Developer
    {
        public WoodDevoloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse(Name);
        }
    }
}

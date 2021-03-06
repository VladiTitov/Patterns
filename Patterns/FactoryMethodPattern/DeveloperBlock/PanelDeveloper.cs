using FactoryMethodPattern.HouseBlock;

namespace FactoryMethodPattern.DeveloperBlock
{
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n) 
        { }

        public override House Create()
        {
            return new PanelHouse(Name);
        }

    }
}

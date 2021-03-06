using FactoryMethodPattern.DeveloperBlock;
using FactoryMethodPattern.HouseBlock;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new PanelDeveloper("ООО МАПИД").Create();
            House house2 = new WoodDevoloper("ИП Беликов").Create();

            Console.ReadLine();
        }
    }
}

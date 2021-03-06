using CommandPattern.MicrowaveClass;
using CommandPattern.TVClass;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            TV tv = new TV();

            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            Microwave microwave = new Microwave();
            pult.SetCommand(new MicrowaveCommand(microwave, 1500));
            pult.PressButton();

            Console.ReadLine();
        }
    }
}

using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.MicrowaveClass
{
    class MicrowaveCommand : ICommand
    {
        Microwave Microwave;
        int Time;

        public MicrowaveCommand(Microwave microwave, int time)
        {
            Microwave = microwave;
            Time = time;
        }


        public void Execute()
        {
            Microwave.StartCooking(Time);
            Microwave.StopCooking();
        }

        public void Undo() => Microwave.StopCooking();
    }
}

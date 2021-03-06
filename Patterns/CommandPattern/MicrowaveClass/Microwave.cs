using System;
using System.Threading.Tasks;

namespace CommandPattern.MicrowaveClass
{
    class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Подогреваем еду");
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking() => Console.WriteLine("Еда подогрета!");
    }
}

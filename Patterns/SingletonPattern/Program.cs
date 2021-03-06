using SingletonPattern.PC;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();

            computer.Launch("Windows 7");
            Console.WriteLine(computer.OS.Name);

            computer.OS = OS.getInsance("Windows 10");
            Console.WriteLine(computer.OS.Name);

            Console.ReadLine();
        }
    }
}

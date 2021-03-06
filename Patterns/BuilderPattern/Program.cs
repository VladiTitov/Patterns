using BuilderPattern.Builder;
using BuilderPattern.Components;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Baker baker = new Baker();
            BreadBuilder builder = new RyeBreadBuilder();
            Bread ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());

            builder = new WheatBreadBuilder();
            Bread whiteBread = baker.Bake(builder);
            Console.WriteLine(whiteBread.ToString());

            Console.ReadLine();
        }
    }
}

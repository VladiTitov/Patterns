using MementoPattern.Objects;
using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState());
            hero.Shoot();

            hero.RestoreState(game.History.Pop());

            hero.Shoot();

            Console.ReadLine();
        }
    }
}

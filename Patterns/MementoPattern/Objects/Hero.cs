using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Objects
{
    class Hero
    {
        private int patrons = 10;
        private int lives = 5;

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine($"Производим выстрел. Осталось {patrons} патронов");
            }
            else Console.WriteLine("Патронов больше нет");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine($"Сохранение игры. Параметры: {patrons} патронов, {lives} жизней");
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine($"Восстановление игры. Параметры: {patrons} патронов, {lives} жизней");
        }
    }
}

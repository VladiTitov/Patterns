using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Objects
{
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}

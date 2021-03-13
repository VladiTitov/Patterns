using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Objects
{
    class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory() => History = new Stack<HeroMemento>();
    }
}

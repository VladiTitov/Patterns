using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.BankClass
{
    class Broker : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Broker(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo stockInfo = (StockInfo)obj;

            if (stockInfo.USD > 30) Console.WriteLine($"Брокер {this.Name} продает доллары; Курс доллара:{stockInfo.USD}");
            else Console.WriteLine($"Брокер {this.Name} покупает доллары; Курс доллара:{stockInfo.USD}");
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}

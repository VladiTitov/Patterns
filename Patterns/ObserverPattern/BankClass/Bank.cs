using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.BankClass
{
    class Bank : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo stockInfo = (StockInfo)obj;
            if (stockInfo.Euro > 40) Console.WriteLine($"Банк {this.Name} продает евро; Курс евро: {stockInfo.Euro}");
            else Console.WriteLine($"Банк {this.Name} покупает евро; Курс евро: {stockInfo.Euro}");
        }
    }
}

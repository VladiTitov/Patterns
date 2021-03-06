using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.BankClass
{
    class Stock : IObservable
    {
        StockInfo StockInfo;

        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            StockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver observer) => observers.Add(observer);

        public void RemoveObserver(IObserver observer) => observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers) observer.Update(StockInfo);
        }

        public void Market()
        {
            Random random = new Random();
            StockInfo.USD = random.Next(20, 40);
            StockInfo.Euro = random.Next(30, 50);
            NotifyObservers();
        }
    }
}

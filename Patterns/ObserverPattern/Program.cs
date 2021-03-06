using ObserverPattern.BankClass;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("МТБанк", stock);
            Broker broker = new Broker("Donald Trump", stock);
            stock.Market();
            broker.StopTrade();
            stock.Market();

            Console.ReadLine();
        }
    }
}

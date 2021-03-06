using MediatorPattern.Interfaces;
using System;

namespace MediatorPattern.Peoples
{
    class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message) => Console.WriteLine($"Сообщение тестеру: {message}");
    }
}

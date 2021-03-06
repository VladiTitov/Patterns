using MediatorPattern.Interfaces;
using System;

namespace MediatorPattern.Peoples
{
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message) => Console.WriteLine($"Сообщение заказчику: {message}");
    }
}

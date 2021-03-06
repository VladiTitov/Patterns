using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Objects;
using System;

namespace ChainOfResponsibilityPattern.HandlerClass
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer) Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else Successor?.Handle(receiver);
        }
    }
}

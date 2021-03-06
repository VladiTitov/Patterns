using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Objects;
using System;

namespace ChainOfResponsibilityPattern.HandlerClass
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer) Console.WriteLine("Выполняем банковский перевод");
            else Successor?.Handle(receiver);
        }
    }
}

using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Objects;
using System;

namespace ChainOfResponsibilityPattern.HandlerClass
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer) Console.WriteLine("Выполняем перевод через PayPal");
            else Successor?.Handle(receiver);
        }
    }
}

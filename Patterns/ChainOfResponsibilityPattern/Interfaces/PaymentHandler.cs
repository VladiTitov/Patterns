using ChainOfResponsibilityPattern.Objects;

namespace ChainOfResponsibilityPattern.Interfaces
{
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}

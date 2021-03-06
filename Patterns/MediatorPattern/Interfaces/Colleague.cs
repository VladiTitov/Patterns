namespace MediatorPattern.Interfaces
{
    abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator _mediator) => this.mediator = _mediator;

        public virtual void Send(string message) => mediator.Send(message, this);

        public abstract void Notify(string message);
    }
}

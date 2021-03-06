using CommandPattern.Interfaces;

namespace CommandPattern.TVClass
{
    class Pult
    {
        ICommand Command;

        public Pult() { }

        public void SetCommand(ICommand command) => Command = command;

        public void PressButton() => Command.Execute();

        public void PressUndo() => Command.Undo();

    }
}

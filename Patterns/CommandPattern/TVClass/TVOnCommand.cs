using CommandPattern.Interfaces;

namespace CommandPattern.TVClass
{
    class TVOnCommand : ICommand
    {
        TV TV;

        public TVOnCommand(TV tvSet) => TV = tvSet;

        public void Execute() => TV.On();

        public void Undo() => TV.Off();
    }
}

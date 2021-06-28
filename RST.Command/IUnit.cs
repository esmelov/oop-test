namespace RST.Command
{
    public interface IUnit
    {
        void ExecuteCommand(ICommand command);
    }

    public abstract class AbstractUnit : IUnit
    {
        public abstract void ExecuteCommand(ICommand command);
    }
}
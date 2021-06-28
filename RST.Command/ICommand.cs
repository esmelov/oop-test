namespace RST.Command
{
    public interface ICommand
    {
        void Execute(IUnit unit);
    }

    public abstract class AbstractCommand : ICommand
    {
        public virtual void Execute(IUnit unit)
            => unit.ExecuteCommand(this);
    }

    public class MoveCommand: AbstractCommand
    { }

    public class FireCommand : AbstractCommand
    { }
}
using System;

namespace RST.Command
{
    public class Car: AbstractUnit
    {
        public override void ExecuteCommand(ICommand command)
        {
            if (command is MoveCommand)
            {
                Console.WriteLine("Машина подвинулась.");
            }
        }
    }
}

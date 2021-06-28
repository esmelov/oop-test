using System;

namespace RST.Command
{
    public class Tank : AbstractUnit
    {
        public override void ExecuteCommand(ICommand command)
        {
            switch (command)
            {
                case MoveCommand _:
                    Console.WriteLine("Танк подвинулся.");
                    break;
                case FireCommand _:
                    Console.WriteLine("Танк выстрелил.");
                    break;
            }
        }
    }
}
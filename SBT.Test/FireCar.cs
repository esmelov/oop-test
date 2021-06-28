using System;
using RST.Command;

namespace SBT.Test
{
    public class FireCar : Car
    {
        public override void ExecuteCommand(ICommand command)
        {
            base.ExecuteCommand(command);

            if (command is FireCommand)
            {
                Console.WriteLine("Машина выстрелила.");
            }
        }
    }
}

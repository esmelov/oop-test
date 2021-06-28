using RST.Command;
using System;

namespace SBT.Test
{
    public class Helicopter : IUnit
    {
        public void ExecuteCommand(ICommand command)
        {
            switch (command)
            {
                case MoveCommand _:
                    Console.WriteLine("Вертолёт подвинулся.");
                    break;
                case RotateCommand _:
                    Console.WriteLine("Вертолёт повернулся.");
                    break;
            }
        }
    }
}

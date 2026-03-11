using System;

namespace FoodiesDelight
{
    public class Restaurant
    {
        private ICommand command;

        public void AddCommand(ICommand command)
        {
            this.command = command;
        }

        public void ProcessCommand()
        {
            if (command != null)
            {
                command.Execute();
            }
        }
    }
}

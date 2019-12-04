using System;

namespace DEV_6
{
   public class CommandInvoker
    {
       ICommand command;
       public void SetCommand(ICommand command)
        {
            this.command = command;
        }

       public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}

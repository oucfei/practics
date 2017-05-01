using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern.UndoRedo
{
    class CommandManager
    {
        private Stack<IUndoableCommand> commandStack = new Stack<IUndoableCommand>();

        public void ExecuteCommand(IUndoableCommand command)
        {
            command.execute();
            commandStack.Push(command);
        }

        public void UndoLastCommand()
        {
            if (commandStack.Any())
            {
                var lastCommand = commandStack.Pop();
                lastCommand.undo();
            }
        }
    }
}

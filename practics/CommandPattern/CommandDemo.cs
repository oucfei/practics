using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern
{
    static class CommandDemo
    {

        public static List<ICommand> produceRequests()
        {
            List<ICommand> queue = new List<ICommand>();
            queue.Add(new Politician());
            queue.Add(new Programmer());

            return queue;
        }

        public static void workOffRequests(List<ICommand> queue)
        {
            foreach (ICommand command in queue)
            {
                command.execute();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern
{
    class Programmer : ICommand
    {
        public void execute()
        {
            Console.WriteLine("sell the bugs, charge extra for the fixes");
        }
    }
}

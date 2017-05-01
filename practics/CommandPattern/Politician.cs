using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern
{
    class Politician : ICommand
    {
        public void execute()
        {
            Console.WriteLine("take money from the rich, take votes from the poor");
        }
    }
}

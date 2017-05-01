using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern.UndoRedo
{
    class DrawSquareCommand : IUndoableCommand
    {
        private Canvas canvas { get; set; }
        private string previousDrawings { get; set; }

        public DrawSquareCommand(Canvas canvas)
        {
            this.canvas = canvas;
            this.previousDrawings = canvas.currentDrawings;
        }

        public void execute()
        {
            this.canvas.DrawSquare();
        }

        public void undo()
        {
            Console.WriteLine("Undoing draw square command");
            this.canvas.currentDrawings = previousDrawings;
        }
    }
}

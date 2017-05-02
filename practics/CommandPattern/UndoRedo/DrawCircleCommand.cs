using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern.UndoRedo
{
    class DrawCircleCommand : IUndoableCommand
    {
        private Canvas canvas { get; set; }

        private string previousDrawings { get; set; }

        public DrawCircleCommand(Canvas canvas)
        {
            this.canvas = canvas;
            this.previousDrawings = canvas.currentDrawings;
        }

        public void execute()
        {
            this.canvas.DrawCircle();
        }

        public void undo()
        { 
            Console.WriteLine("Undoing draw circle command");
            this.canvas.currentDrawings = this.previousDrawings;
        }
    }
}

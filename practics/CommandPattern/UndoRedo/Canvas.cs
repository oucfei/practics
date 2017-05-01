using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.CommandPattern.UndoRedo
{
    class Canvas
    {
        public string currentDrawings { get; set; }

        public void DrawSquare()
        {
            currentDrawings += ", Square";
            Console.WriteLine("drawing a square");
        }

        public void DrawCircle()
        {
            currentDrawings += ", Circle";
            Console.WriteLine("drawing a circle");
        }
    }
}

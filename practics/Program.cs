using practics.CommandPattern;
using practics.CommandPattern.UndoRedo;
using practics.IteratorPattern;
using practics.OOPConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CommandPattern

            //var queue = CommandDemo.produceRequests();
            //CommandDemo.workOffRequests(queue);

            //var canvas = new Canvas();
            //var commandManager = new CommandManager();
            //commandManager.ExecuteCommand(new DrawSquareCommand(canvas));
            //commandManager.ExecuteCommand(new DrawSquareCommand(canvas));
            //commandManager.ExecuteCommand(new DrawCircleCommand(canvas));
            //commandManager.ExecuteCommand(new DrawSquareCommand(canvas));
            //commandManager.ExecuteCommand(new DrawCircleCommand(canvas));

            //commandManager.UndoLastCommand();
            //commandManager.UndoLastCommand();
            //commandManager.UndoLastCommand();
            //Console.WriteLine("Canvas now has:");
            //Console.WriteLine(canvas.currentDrawings);

            #endregion


            #region OOPConcept
            //var animal = new Animal();
            //animal.eat();

            //var dog = new Dog();
            //dog.eat();

            #endregion

            #region IteratorPattern
            var iteratorType = new MyIteratorType();
            foreach (var s in iteratorType)
            {
                Console.WriteLine(s);
            }
            #endregion
            Console.ReadKey();
        }
    }
}

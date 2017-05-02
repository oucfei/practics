using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.OOPConcept
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eat like an animal!");
        }

        //public abstract void play();
    }

    class Dog : Animal
    {
        //public override void eat()
        //{
        //    Console.WriteLine("eat like a dog!");
        //}

        public void play()
        {
            Console.WriteLine("play like a dog!");
        }
    }
}

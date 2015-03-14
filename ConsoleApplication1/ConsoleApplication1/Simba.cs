using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Simba:GoodGuy
    {
             public Simba()
            : base("Simba", 100, 100, .6, 20, 18, "Hello", "Bye", "Backflip", "Slash", "Roar")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to backflip his enemy into the fire. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to slash his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to roar his enemy to death.");
            return 5;
        }
    }
}

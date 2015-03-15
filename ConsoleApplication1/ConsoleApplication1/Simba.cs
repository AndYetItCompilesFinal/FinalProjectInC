using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Simba:GoodGuy
    {
             public Simba()
            : base("Simba", 70, 70, .6, 20, 14, "Pounce", "Slash", "Roar")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to pounce on his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to slash his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to roar his enemy to death.");
            return 5;
        }
    }
}

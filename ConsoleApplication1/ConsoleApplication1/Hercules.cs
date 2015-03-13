using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hercules : GoodGuy
    {
        public Hercules()
            : base("Hercules", 100, 100, .7, 10, 4, "Hello", "Bye", "Punch", "Use Pegasus", "Smash")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to punch the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to call Pegusus to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to smash the enemy.");
            return 5;
        }
    }
}

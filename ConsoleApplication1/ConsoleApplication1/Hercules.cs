using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hercules : GoodGuy
    {
        public Hercules()
            : base("Hercules", 75, 75, .7, 15, 15, "Punch", "Send Pegasus", "Sword")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to punch the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to send Pegusus to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to use sword on the enemy.");
            return 5;
        }
    }
}

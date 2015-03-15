using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RobinHood : GoodGuy
    {
        public RobinHood()
            : base("Robin Hood", 60, 60, .7, 20, 20, "Bow and Arrow", "Duel", "Steal Health")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to shoot the enemy with his bow and arrow. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to duel with the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to steal health from the enemy.");
            return 5;
        }
    }
}

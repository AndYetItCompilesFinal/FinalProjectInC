
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Shanyu : BadGuy
    {
        public Shanyu()
            : base("Shanyu", 100, 100, .8, 19, 15, "Ninja Status", "Trip Enemy", "Sword")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to use ninja moves on his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to trip the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword.");
            return 5;
        }
    }
}

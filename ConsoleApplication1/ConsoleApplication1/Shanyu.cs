
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Shanyu : BadGuy
    {
        public Shanyu()
            : base("Shanyu", 100, 100, .8, 19, 15, "Ambush", "Use Falcon", "Sword")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to ambush his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to use falcon on his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to slash his enemy with his sword.");
            return 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Scar : BadGuy
    {
        public Scar()
            : base("Scar", 75, 75, .6, 19, 15, "Slash", "Kill Father", "Send hyenas")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to kill his enemy's father. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send hyenas to attack his enemy.");
            return 5;
        }
    }
}
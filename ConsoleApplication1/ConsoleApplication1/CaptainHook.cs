using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class CaptainHook : BadGuy
    {
        public CaptainHook()
            : base("Captain Hook", 75, 75, .6, 19, 15, "Use Hook", "Force off the plank", "Cannon")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his hook. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to force his enemy off the plank. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to shoot a cannon at his enemy.");
            return 5;
        }
    }
}
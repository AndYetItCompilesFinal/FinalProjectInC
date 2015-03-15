using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Stitch : GoodGuy
    {
        public Stitch()
            : base("Stitch", 50, 50, .5, 9, 10,  "Claw", "Plasma Gun", "Chomp")
        {

        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to claw his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to shoot his enemy with a plasma gun. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to chomp his enemy.");
            return 5;
        }


    }
}

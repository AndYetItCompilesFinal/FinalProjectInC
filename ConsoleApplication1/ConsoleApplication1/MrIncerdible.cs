using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MrIncerdible:GoodGuy
    {
        public MrIncerdible()
            : base("Mr Incredible", 75, 75, .6, 8, 15,"Throw Car", "Super Punch", "Body Slam")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to throw car at the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to super punch the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to body slam the enemy.");
            return 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ChickenLittle : GoodGuy
    {
        public ChickenLittle()
            : base("Chicken Little", 50, 50, .3, 5, 7, "Throw Eggs", "Peck", "Throw Dodgeball")
        {
    
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to throw eggs at the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to peck the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to throw dodgeball at the enemy.");
            return 5;
        }

    }
}

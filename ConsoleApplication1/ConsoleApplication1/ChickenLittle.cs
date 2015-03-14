using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ChickenLittle : GoodGuy
    {
        public ChickenLittle()
            : base("Chicken Little", 50, 50, .3, 13, 18, "Egg Throw", "Claw", "Tell Dad")
        {
    
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to hit the enemy with an egg. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to claw the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to tell Dad about the enemy.");
            return 5;
        }

    }
}

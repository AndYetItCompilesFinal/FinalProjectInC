using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Belle:GoodGuy
    {
        public Belle()
            : base("Belle", 50, 50, .5, 16, 12, "Book", "Punch", "Send Beast")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to hit the enemy with her book. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to punch the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send beast to attack the enemy.");
            return 5;
        }
    }
}

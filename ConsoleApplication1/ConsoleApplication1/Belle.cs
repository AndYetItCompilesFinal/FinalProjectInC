using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Belle:GoodGuy
    {
        public Belle()
            : base("Belle", 50, 50, .5, 16, 12, "Hello", "Bye", "attack 1", "attack 2", "attack3")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to trip the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to jump on and attack the enemy.");
            return 5;
        }
    }
}

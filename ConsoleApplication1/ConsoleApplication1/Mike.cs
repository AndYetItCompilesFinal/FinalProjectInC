using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mike:GoodGuy
    {
        public Mike()
            : base("Mike Wazowski", 75, 75, .4, 15, 19, "Hello", "Bye", "Terrify", "Sneak", "Bite")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to terrify the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to sneak attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to bite the enemy.");
            return 5;
        }
    }
}

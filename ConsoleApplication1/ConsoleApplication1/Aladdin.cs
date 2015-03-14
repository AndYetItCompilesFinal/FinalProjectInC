using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Aladdin:GoodGuy
    {
        public Aladdin()
            : base("Aladdin", 50, 50, .3, 12, 14, "Use Sword", "Trip Enemy", "Physical Attack")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to trip the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to jump on and attack the enemy.");
            return 5;
        }
    }
}

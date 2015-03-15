using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Aladdin:GoodGuy
    {
        public Aladdin()
            : base("Aladdin", 70, 70, .6, 15, 14, "Use Sword", "Throw Apple", "Send Abu")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to throw an apple at his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " sent Abu to try and claw the enemy.");
            return 5;
        }
    }
}

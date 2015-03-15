using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Mulan:GoodGuy
    {
        public Mulan()
            : base("Mulan", 60, 60, .7, 20, 10, "Punch", "Use Cannon", "Send Mushu")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to punch the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to use connon on the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send mushu to attack the enemy.");
            return 5;
        }
    }
}

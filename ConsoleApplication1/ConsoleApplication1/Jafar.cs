using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Jafar : BadGuy
    {
        public Jafar()
            : base("Jafar", 100, 100, .6, 19, 15, "Become Snake", "Send Iago", "Hit with Staff")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to become a snake and bite his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to send Iago to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to hit his enemy with staff.");
            return 5;
        }
    }
}

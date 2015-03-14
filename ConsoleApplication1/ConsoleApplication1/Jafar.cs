using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Jafar : BadGuy
    {
        public Jafar()
            : base("Jafar", 100, 100, .8, 19, 15, "Use Snake", "Use Iago", "Use Staff")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to attack the enemy as a snake. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + "tried to use Iago to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to use his staff to attack the enemy.");
            return 5;
        }
    }
}

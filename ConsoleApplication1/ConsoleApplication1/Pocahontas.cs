using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pocahontas : GoodGuy
    {
        public Pocahontas()
            : base("Pocahontas", 50, 50, .5, 10, 10, "Swipe Feet", "Color of the wind", "Send animals")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to swipe her enemies feet. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to use the wind to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send animals to attack the enemy.");
            return 5;
        }

    }
}

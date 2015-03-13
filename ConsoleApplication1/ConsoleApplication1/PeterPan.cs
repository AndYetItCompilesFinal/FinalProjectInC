using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PeterPan : GoodGuy
    {
        public PeterPan()
            : base("Peter Pan", 50, 50, .2, 20, 20, "Hello", "Bye", "Sword", "Shadow Attack", "Duel")
        {
  
        }
        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to attack the enemy with his shadow. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to duel with the enemy.");
            return 5;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PeterPan : GoodGuy
    {
        public PeterPan()
            : base("Peter Pan", 70, 70, .6, 20, 12,"Sword", "Shadow Attack", "Send lost boys")
        {
  
        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to slash the enemy with his sword. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to attack the enemy with his shadow. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send lost boys to attack the enemy.");
            return 5;
        }

    }
}

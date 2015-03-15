using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mike:GoodGuy
    {
        public Mike()
            : base("Mike Wazowski", 75, 75, .4, 15, 17, "Terrify", "Send Sully", "Bite")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to terrify the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to send Sully to attack the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to bite the enemy.");
            return 5;
        }
    }
}

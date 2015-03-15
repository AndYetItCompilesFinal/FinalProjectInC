using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Belle:GoodGuy
    {
        public Belle()
            : base("Belle", 70, 70, .4, 16, 12, "Throw Book", "Use Lumiere", "Send Beast")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to throw book at the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to use Lumiere to set the enemy on fire. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to send Beast to attack the enemy.");
            return 5;
        }
    }
}

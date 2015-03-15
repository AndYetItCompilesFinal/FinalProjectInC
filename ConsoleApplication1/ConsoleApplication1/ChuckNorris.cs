using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ChuckNorris:BadGuy
    {
        public ChuckNorris()
            : base("Chuck Norris", 10000, 10000, .9, 20, 50, "Punch", "Kick", "Body Slam")
        {

        }
        public override int Attack1()
        {
            Console.WriteLine(this.GetName() + " tried to punch his enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.GetName() + " tried to kick his enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.GetName() + " tried to body slam his enemy.");
            return 5;
        }
    }
}

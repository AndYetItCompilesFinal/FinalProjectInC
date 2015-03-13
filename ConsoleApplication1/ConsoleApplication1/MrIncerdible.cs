using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MrIncerdible:GoodGuy
    {
        public MrIncerdible()
            : base("Mr Incredible", 100, 100, .6, 8, 11, "Hello", "Bye", "Manhandle", "Super Punch", "Bodyslam")
        {
        }

        public override int Attack1()
        {
            Console.WriteLine(this.Name + " tried to manhandle the enemy. ");
            return 15;
        }

        public override int Attack2()
        {
            Console.WriteLine(this.Name + "tried to super punch the enemy. ");
            return 5;
        }

        public override int Attack3()
        {
            Console.WriteLine(this.Name + " tried to bodyslam the enemy.");
            return 5;
        }
    }
}

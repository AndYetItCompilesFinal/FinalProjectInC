using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PotionBehavior
    {
        public string Description;
        public int Hp;

        public override string ToString()
        {
            return Description;
        }


        public string getDescription()
        {
            return ", " + Description;
        }

        public int getHP()
        {
            return Hp;
        }
    }
}

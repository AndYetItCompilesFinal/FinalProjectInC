using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PotionBehavior
    {
        public string description;
        public int HP;

        public override string ToString()
        {
            return description;
        }


        public string getDescription()
        {
            return ", " + description;
        }

        public int getHP()
        {
            return HP;
        }
    }
}

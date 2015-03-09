using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class UniqueLevelItemBehavior
    {
        public string description;
        public int quantity;

        public override string ToString()
        {
            if (quantity == 1)
            {
                return description;
            }
            else
                return description + " (" + quantity + ")";   
        }

        public string getDescription()
        {
            return ", " + description;
        }

    }
}

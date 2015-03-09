using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UniqueItem:UniqueLevelItemBehavior
    {
        public UniqueItem(string description)
        {
            this.quantity = 1;
            this.description = description;
        }
    }
}

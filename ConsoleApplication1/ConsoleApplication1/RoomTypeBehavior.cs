using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class RoomTypeBehavior
    {
        public string description;
        public override string ToString()
        {
            return this.description;
        }

    }
}

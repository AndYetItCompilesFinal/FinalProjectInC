using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class RoomTypeBehavior
    {
        private string description;
        public RoomTypeBehavior(string description)
        {
            this.description = description;
        }
        public override string ToString()
        {
            return this.description;
        }

    }
}

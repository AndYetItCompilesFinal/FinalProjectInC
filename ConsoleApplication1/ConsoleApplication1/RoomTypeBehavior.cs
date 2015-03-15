using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class RoomTypeBehavior
    {
        private string Description;
        public RoomTypeBehavior(string description)
        {
            this.Description = description;
        }
        public override string ToString()
        {
            return this.Description;
        }

    }
}

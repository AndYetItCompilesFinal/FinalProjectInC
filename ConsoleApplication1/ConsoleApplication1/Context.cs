using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }

        public void SetState(State state)
        {
            this.state = state;
        }
    }
}

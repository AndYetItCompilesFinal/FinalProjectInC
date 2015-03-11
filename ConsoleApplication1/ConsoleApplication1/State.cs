using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface State
    {
        bool DoAction(Context context,Room room, Party party, Backpack pack,Level level, BattleState battleState);
    }
}

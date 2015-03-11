using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class UniqueState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState)
        {
            context.setState(this);
            pack.add(room.unique);
            Console.WriteLine(room.unique.description + " added to backpack\n");
            room.unique = new NoUniqueItems();
            room.size--;
            return false;
        }
    }
}

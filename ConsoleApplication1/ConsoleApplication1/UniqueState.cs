using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class UniqueState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState, BadGuy[] bad)
        {
            context.setState(this);
            pack.Add(room.GetUnique());
            Console.WriteLine(room.GetUnique().GetDescription() + " added to backpack\n");
            room.SetUnique(new NoUniqueItems());
            room.SubtractSize();
            return false;
        }
    }
}

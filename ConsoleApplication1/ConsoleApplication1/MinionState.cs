using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MinionState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level)
        {
            Console.WriteLine("There is a bad guy in the room!!");
            Console.WriteLine("Battle " + room.minion.numofminions + "Minions");
            party.enemiesDefeated += room.minion.numofminions;
            //BattlePhase.startBattle(party, b);
            return false;
        }
    }
}
